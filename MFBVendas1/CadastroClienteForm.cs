using System;
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
                this.Close();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (clienteId.HasValue)
            {
                using (SqlConnection connection = dbConnection.AbrirConexao())
                {
                    string query = "DELETE FROM Clientes WHERE id = @ClienteId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClienteId", clienteId);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cliente deletado com sucesso!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Nenhum cliente selecionado para deletar.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}