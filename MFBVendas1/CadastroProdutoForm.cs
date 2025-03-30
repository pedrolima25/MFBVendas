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
            using (SqlConnection connection = dbConnection.AbrirConexao())
            {
                string query = "SELECT * FROM Produtos WHERE ProdutoId = @ProdutoId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProdutoId", produtoId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtNomeProduto.Text = reader["nome"].ToString();
                    txtPreco.Text = reader["preco"].ToString();
                    txtQuantidade.Text = reader["estoque"].ToString();
                }
                dbConnection.FecharConexao();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = dbConnection.AbrirConexao())
            {
                string query;
                if (produtoId.HasValue)
                {
                    query = "UPDATE Produtos SET nome = @Nome, preco = @Preco, estoque = @Estoque WHERE ProdutoId = @ProdutoId";
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
                dbConnection.FecharConexao();
                MessageBox.Show("Produto salvo com sucesso!");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}