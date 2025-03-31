using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace SistemaDeVendasMFB
{
    public partial class PDVForm : Form
    {
        private Conexao dbConnection;
        private DataTable dataTable;

        public PDVForm()
        {
            InitializeComponent();
            dbConnection = new Conexao();
            dataTable = new DataTable();
            dataTable.Columns.Add("Código");
            dataTable.Columns.Add("Produto");
            dataTable.Columns.Add("Quantidade");
            dataTable.Columns.Add("Preço Unitário");
            dataTable.Columns.Add("Total");
            dataGridViewProdutos.DataSource = dataTable;
            AtualizarTotal();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            AdicionarProdutoPorCodigo(txtCodigoProduto.Text);
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            PesquisarProdutoPorNome(txtNomeProduto.Text);
        }

        private void AdicionarProdutoPorCodigo(string codigoProduto)
        {
            if (string.IsNullOrEmpty(codigoProduto))
            {
                MessageBox.Show("Por favor, insira o código do produto.");
                return;
            }

            using (SqlConnection connection = dbConnection.AbrirConexao())
            {
                string query = "SELECT nome, preco FROM Produtos WHERE codigo = @Codigo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Codigo", codigoProduto);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string nomeProduto = reader["nome"].ToString();
                    decimal precoUnitario = Convert.ToDecimal(reader["preco"]);
                    AdicionarOuAtualizarProdutoNaTabela(codigoProduto, nomeProduto, precoUnitario);
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                }
                dbConnection.FecharConexao();
            }

            txtCodigoProduto.Clear();
            txtCodigoProduto.Focus();
        }

        private void AdicionarOuAtualizarProdutoNaTabela(string codigoProduto, string nomeProduto, decimal precoUnitario)
        {
            DataRow[] existingRows = dataTable.Select($"Código = '{codigoProduto}'");
            if (existingRows.Length > 0)
            {
                // Produto já existe na tabela, atualizar a quantidade e o total
                DataRow row = existingRows[0];
                int quantidade = Convert.ToInt32(row["Quantidade"]) + 1;
                row["Quantidade"] = quantidade;
                row["Total"] = quantidade * precoUnitario;
            }
            else
            {
                // Produto não existe na tabela, adicionar nova linha
                DataRow row = dataTable.NewRow();
                row["Código"] = codigoProduto;
                row["Produto"] = nomeProduto;
                row["Quantidade"] = 1;
                row["Preço Unitário"] = precoUnitario;
                row["Total"] = precoUnitario;
                dataTable.Rows.Add(row);
            }

            AtualizarTotal();
        }

        private void PesquisarProdutoPorNome(string nomeProduto)
        {
            if (string.IsNullOrEmpty(nomeProduto))
            {
                MessageBox.Show("Por favor, insira o nome do produto.");
                return;
            }

            using (SqlConnection connection = dbConnection.AbrirConexao())
            {
                string query = "SELECT codigo, nome, preco FROM Produtos WHERE nome LIKE @Nome";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", "%" + nomeProduto + "%");
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string codigoProduto = reader["codigo"].ToString();
                    string nomeProdutoEncontrado = reader["nome"].ToString();
                    decimal precoUnitario = Convert.ToDecimal(reader["preco"]);
                    AdicionarOuAtualizarProdutoNaTabela(codigoProduto, nomeProdutoEncontrado, precoUnitario);
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                }
                dbConnection.FecharConexao();
            }

            txtNomeProduto.Clear();
            txtNomeProduto.Focus();
        }

        private void AtualizarTotal()
        {
            decimal total = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                total += Convert.ToDecimal(row["Total"]);
            }
            txtTotal.Text = total.ToString("C");
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto adicionado.");
                return;
            }

            using (SqlConnection connection = dbConnection.AbrirConexao())
            {
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Insere a venda e obtém o id da venda
                    string query = "INSERT INTO Vendas (id_cliente, data_venda, total) OUTPUT INSERTED.id VALUES (@IdCliente, @Data, @Total)";
                    SqlCommand command = new SqlCommand(query, connection, transaction);
                    command.Parameters.AddWithValue("@IdCliente", 1); // Supondo que o id_cliente é 1 para este exemplo
                    command.Parameters.AddWithValue("@Data", DateTime.Now);
                    command.Parameters.AddWithValue("@Total", decimal.Parse(txtTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture));
                    int vendaId = (int)command.ExecuteScalar();

                    // Insere os itens da venda
                    foreach (DataRow row in dataTable.Rows)
                    {
                        query = "INSERT INTO ItensVenda (id_venda, id_produto, quantidade, preco_unitario, subtotal) VALUES (@VendaId, @CodigoProduto, @Quantidade, @PrecoUnitario, @Subtotal)";
                        command = new SqlCommand(query, connection, transaction);
                        command.Parameters.AddWithValue("@VendaId", vendaId);
                        command.Parameters.AddWithValue("@CodigoProduto", row["Código"].ToString());
                        command.Parameters.AddWithValue("@Quantidade", Convert.ToInt32(row["Quantidade"]));
                        command.Parameters.AddWithValue("@PrecoUnitario", Convert.ToDecimal(row["Preço Unitário"]));
                        command.Parameters.AddWithValue("@Subtotal", Convert.ToDecimal(row["Total"]));
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Venda finalizada com sucesso!");
                    dataTable.Clear();
                    AtualizarTotal();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erro ao finalizar venda: " + ex.Message);
                }
                dbConnection.FecharConexao();
            }
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            AtualizarTotal();
        }
    }
}