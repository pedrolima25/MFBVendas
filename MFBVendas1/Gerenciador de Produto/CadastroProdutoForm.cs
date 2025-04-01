using System;
using System.Data;
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
            CarregarListaProdutos();
            if (produtoId.HasValue)
            {
                CarregarProduto();
            }
        }

        private void CarregarProduto()
        {
            SqlConnection connection = null;
            try
            {
                connection = dbConnection.AbrirConexao();
                string query = "SELECT nome, preco, estoque FROM Produtos WHERE codigo = @ProdutoId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProdutoId", produtoId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtNomeProduto.Text = reader["nome"].ToString();
                    txtPrecoProduto.Text = reader["preco"].ToString();
                    txtQuantidadeProduto.Text = reader["estoque"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produto: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    dbConnection.FecharConexao();
                }
            }
        }

        private void CarregarListaProdutos()
        {
            SqlConnection connection = null;
            try
            {
                connection = dbConnection.AbrirConexao();
                string query = "SELECT codigo, nome, preco, estoque FROM Produtos";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvListaProdutos.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    dbConnection.FecharConexao();
                }
            }
        }

        private void dgvListaProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListaProdutos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvListaProdutos.SelectedRows[0];
                produtoId = Convert.ToInt32(selectedRow.Cells["codigo"].Value);
                txtNomeProduto.Text = selectedRow.Cells["nome"].Value.ToString();
                txtPrecoProduto.Text = selectedRow.Cells["preco"].Value.ToString();
                txtQuantidadeProduto.Text = selectedRow.Cells["estoque"].Value.ToString();
            }
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
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
                command.Parameters.AddWithValue("@Preco", txtPrecoProduto.Text);
                command.Parameters.AddWithValue("@Estoque", txtQuantidadeProduto.Text);

                if (produtoId.HasValue)
                {
                    command.Parameters.AddWithValue("@ProdutoId", produtoId);
                }

                command.ExecuteNonQuery();
                MessageBox.Show("Produto salvo com sucesso!");
                CarregarListaProdutos();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar produto: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    dbConnection.FecharConexao();
                }
            }
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (!produtoId.HasValue)
            {
                MessageBox.Show("Nenhum produto selecionado para exclusão.");
                return;
            }

            using (SqlConnection connection = dbConnection.AbrirConexao())
            {
                try
                {
                    // Verificar se há registros associados ao produto
                    string query = "SELECT COUNT(*) FROM ItensVenda WHERE id_produto = @ProdutoId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProdutoId", produtoId);
                    int registrosCount = (int)command.ExecuteScalar();

                    if (registrosCount > 0)
                    {
                        MessageBox.Show("Não é possível excluir o produto. Existem registros associados a este produto.");
                        return;
                    }

                    // Excluir o produto
                    query = "DELETE FROM Produtos WHERE codigo = @ProdutoId";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProdutoId", produtoId);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Produto excluído com sucesso!");
                    CarregarListaProdutos();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir produto: " + ex.Message);
                }
                dbConnection.FecharConexao();
            }
        }



        private void LimparCampos()
        {
            produtoId = null;
            txtNomeProduto.Clear();
            txtPrecoProduto.Clear();
            txtQuantidadeProduto.Clear();
        }
    }
}
