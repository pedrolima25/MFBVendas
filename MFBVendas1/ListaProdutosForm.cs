using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaDeVendasMFB
{
    public partial class ListaProdutosForm : Form
    {
        private Conexao dbConnection;

        public ListaProdutosForm()
        {
            InitializeComponent();
            dbConnection = new Conexao();
            LoadProdutos();
        }

        private void LoadProdutos()
        {
            using (SqlConnection connection = dbConnection.AbrirConexao())
            {
                string query = "SELECT * FROM Produtos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewProdutos.DataSource = dataTable;
                dbConnection.FecharConexao();
            }
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            CadastroProdutoForm cadastroProdutoForm = new CadastroProdutoForm();
            cadastroProdutoForm.Show();
        }

        private void btnEditProduto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedRows.Count > 0)
            {
                int produtoId = Convert.ToInt32(dataGridViewProdutos.SelectedRows[0].Cells[0].Value);
                CadastroProdutoForm cadastroProdutoForm = new CadastroProdutoForm(produtoId);
                cadastroProdutoForm.Show();
            }
            else
            {
                MessageBox.Show("Selecione um produto para editar.");
            }
        }

        private void btnDeleteProduto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedRows.Count > 0)
            {
                int produtoId = Convert.ToInt32(dataGridViewProdutos.SelectedRows[0].Cells[0].Value);
                if (dbConnection.TestarPermissaoDeletar())
                {
                    using (SqlConnection connection = dbConnection.AbrirConexao())
                    {
                        string query = "DELETE FROM Produtos WHERE ProdutoId = @ProdutoId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ProdutoId", produtoId);

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Produto excluído com sucesso!");
                            LoadProdutos();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Erro ao excluir o produto: " + ex.Message);
                        }
                        finally
                        {
                            dbConnection.FecharConexao();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Você não tem permissão para deletar produtos.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.");
            }
        }
    }
    }