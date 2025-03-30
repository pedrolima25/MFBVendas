using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaDeVendasMFB
{
    public partial class ListaClientesForm : Form
    {
        private Conexao dbConnection;

        public ListaClientesForm()
        {
            InitializeComponent();
            dbConnection = new Conexao();
            LoadClientes();
        }

        private void LoadClientes()
        {
            using (SqlConnection connection = dbConnection.AbrirConexao())
            {
                string query = "SELECT * FROM Clientes";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewClientes.DataSource = dataTable;
                dbConnection.FecharConexao();
            }
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            CadastroClienteForm cadastroClienteForm = new CadastroClienteForm();
            cadastroClienteForm.Show();
        }

        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                int clienteId = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells[0].Value);
                CadastroClienteForm cadastroClienteForm = new CadastroClienteForm(clienteId);
                cadastroClienteForm.Show();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para editar.");
            }
        }

        private void btnDeleteCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                int clienteId = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells[0].Value);
                using (SqlConnection connection = dbConnection.AbrirConexao())
                {
                    string query = "DELETE FROM Clientes WHERE ClienteId = @ClienteId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClienteId", clienteId);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Cliente excluído com sucesso!");
                        LoadClientes();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao excluir o cliente: " + ex.Message);
                    }
                    finally
                    {
                        dbConnection.FecharConexao();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para excluir.");
            }
        }
    }
}