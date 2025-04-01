using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaDeVendasMFB
{
    public partial class CadastroClienteForm : Form
    {
        private int? clienteId;
        private Conexao dbConnection;

        public CadastroClienteForm(int? clienteId = null)
        {
            InitializeComponent();
            this.clienteId = clienteId;
            dbConnection = new Conexao();
            CarregarListaClientes();
            if (clienteId.HasValue)
            {
                LoadCliente();
            }
        }

        private void LoadCliente()
        {
            using (SqlConnection connection = dbConnection.AbrirConexao())
            {
                string query = "SELECT * FROM Clientes WHERE id = @ClienteId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClienteId", clienteId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtNomeCliente.Text = reader["nome"].ToString();
                    txtCPF_CNPJ.Text = reader["cpf_cnpj"].ToString();
                    txtTelefone.Text = reader["telefone"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtEndereco.Text = reader["endereco"].ToString();
                }
            }
        }

        private void CarregarListaClientes()
        {
            SqlConnection connection = null;
            try
            {
                connection = dbConnection.AbrirConexao();
                string query = "SELECT id, nome, cpf_cnpj, telefone, email, endereco FROM Clientes";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvListaClientes.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    dbConnection.FecharConexao();
                }
            }
        }

        private void dgvListaClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListaClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvListaClientes.SelectedRows[0];
                clienteId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                txtNomeCliente.Text = selectedRow.Cells["nome"].Value.ToString();
                txtCPF_CNPJ.Text = selectedRow.Cells["cpf_cnpj"].Value.ToString();
                txtTelefone.Text = selectedRow.Cells["telefone"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["email"].Value.ToString();
                txtEndereco.Text = selectedRow.Cells["endereco"].Value.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = dbConnection.AbrirConexao())
            {
                string query;
                if (clienteId.HasValue)
                {
                    query = "UPDATE Clientes SET nome = @Nome, cpf_cnpj = @CPF_CNPJ, telefone = @Telefone, email = @Email, endereco = @Endereco WHERE id = @ClienteId";
                }
                else
                {
                    query = "INSERT INTO Clientes (nome, cpf_cnpj, telefone, email, endereco) VALUES (@Nome, @CPF_CNPJ, @Telefone, @Email, @Endereco)";
                }

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", txtNomeCliente.Text);
                command.Parameters.AddWithValue("@CPF_CNPJ", txtCPF_CNPJ.Text);
                command.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Endereco", txtEndereco.Text);

                if (clienteId.HasValue)
                {
                    command.Parameters.AddWithValue("@ClienteId", clienteId);
                }

                command.ExecuteNonQuery();
                MessageBox.Show("Cliente salvo com sucesso!");
                CarregarListaClientes();
                LimparCampos();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (!clienteId.HasValue)
            {
                MessageBox.Show("Nenhum cliente selecionado para deletar.");
                return;
            }

            using (SqlConnection connection = dbConnection.AbrirConexao())
            {
                try
                {
                    // Verificar se há vendas associadas ao cliente
                    string query = "SELECT COUNT(*) FROM Vendas WHERE id_cliente = @ClienteId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClienteId", clienteId);
                    int vendasCount = (int)command.ExecuteScalar();

                    if (vendasCount > 0)
                    {
                        MessageBox.Show("Não é possível deletar o cliente. Existem vendas associadas a este cliente.");
                        return;
                    }

                    // Excluir o cliente
                    query = "DELETE FROM Clientes WHERE id = @ClienteId";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClienteId", clienteId);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cliente deletado com sucesso!");
                    CarregarListaClientes();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar cliente: " + ex.Message);
                }
                dbConnection.FecharConexao();
            }
        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparCampos()
        {
            clienteId = null;
            txtNomeCliente.Clear();
            txtCPF_CNPJ.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
        }
    }
}


