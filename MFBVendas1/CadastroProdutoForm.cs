using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaDeVendasMFB
{
    public partial class CadastroProdutoForm : Form
    {
        private int? produtoId;
        private Conexao dbConnection;

        public CadastroProdutoForm(int? produtoId = null)
        {
            InitializeComponent();
            this.produtoId = produtoId;
            dbConnection = new Conexao();
            if (produtoId.HasValue)
            {
                LoadProduto();
            }
        }

        private void LoadProduto()
        {
            SqlConnection connection = null;
            try
            {
                connection = dbConnection.AbrirConexao();
                string query = "SELECT * FROM Produtos WHERE codigo = @ProdutoId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProdutoId", produtoId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtNomeProduto.Text = reader["nome"].ToString();
                    txtPreco.Text = reader["preco"].ToString();
                    txtQuantidade.Text = reader["estoque"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produto: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.FecharConexao();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            try
            {
                connection = dbConnection.AbrirConexao();
                string query;
                if (produtoId.HasValue)
                {
                    query = "UPDATE Produtos SET nome = @Nome, preco = @Preco, estoque = @Estoque WHERE codigo = @ProdutoId";
                }
                else
                {
                    query = "INSERT INTO Produtos (nome, preco, estoque) VALUES (@Nome, @Preco, @Estoque)";
                }

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", txtNomeProduto.Text);
                command.Parameters.AddWithValue("@Preco", txtPreco.Text);
                command.Parameters.AddWithValue("@Estoque", txtQuantidade.Text);

                if (produtoId.HasValue)
                {
                    command.Parameters.AddWithValue("@ProdutoId", produtoId);
                }

                command.ExecuteNonQuery();
                MessageBox.Show("Produto salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar produto: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.FecharConexao();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!produtoId.HasValue)
            {
                MessageBox.Show("Nenhum produto selecionado para exclusão.");
                return;
            }

            SqlConnection connection = null;
            try
            {
                connection = dbConnection.AbrirConexao();

                // Verificar se o produto existe
                string selectQuery = "SELECT [codigo], [nome], [preco], [estoque] FROM [dbo].[Produtos] WHERE [codigo] = @ProdutoId";
                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@ProdutoId", produtoId);
                SqlDataReader reader = selectCommand.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Produto não encontrado.");
                    return;
                }
                reader.Close();

                // Verificar permissão para deletar
                if (!dbConnection.TestarPermissaoDeletar())
                {
                    MessageBox.Show("Você não tem permissão para deletar produtos.");
                    return;
                }

                // Deletar o produto
                string deleteQuery = "DELETE FROM Produtos WHERE codigo = @ProdutoId";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@ProdutoId", produtoId);
                deleteCommand.ExecuteNonQuery();

                MessageBox.Show("Produto excluído com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.FecharConexao();
                }
            }
        }
    }
}
