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
                string query = "SELECT * FROM Clientes WHERE ClienteId = @ClienteId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClienteId", clienteId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtNomeCliente.Text = reader["nome"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtTelefone.Text = reader["telefone"].ToString();
                }
                dbConnection.FecharConexao();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = dbConnection.AbrirConexao())
            {
                string query;
                if (clienteId.HasValue)
                {
                    query = "UPDATE Clientes SET nome = @Nome, email = @Email, telefone = @Telefone WHERE ClienteId = @ClienteId";
                }
                else
                {
                    query = "INSERT INTO Clientes (nome, email, telefone) VALUES (@Nome, @Email, @Telefone)";
                }

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", txtNomeCliente.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Telefone", txtTelefone.Text);

                if (clienteId.HasValue)
                {
                    command.Parameters.AddWithValue("@ClienteId", clienteId);
                }

                command.ExecuteNonQuery();
                dbConnection.FecharConexao();
                MessageBox.Show("Cliente salvo com sucesso!");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}