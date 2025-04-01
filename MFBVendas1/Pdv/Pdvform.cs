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
        private int? clienteId;

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
            txtCodigoProduto.KeyDown += new KeyEventHandler(txtCodigoProduto_KeyDown);
            txtNomeProduto.KeyDown += new KeyEventHandler(txtNomeProduto_KeyDown);
            txtNomeProduto.AutoCompleteCustomSource = new AutoCompleteStringCollection();

            CarregarNomesProdutos();
        }

        private void CarregarNomesProdutos()
        {
            using (SqlConnection connection = dbConnection.AbrirConexao())
            {
                string query = "SELECT nome FROM Produtos";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                AutoCompleteStringCollection nomesProdutos = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    nomesProdutos.Add(reader["nome"].ToString());
                }
                txtNomeProduto.AutoCompleteCustomSource = nomesProdutos;
                dbConnection.FecharConexao();
            }
        }
        private void txtCodigoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdicionarProdutoPorCodigo(txtCodigoProduto.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtNomeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PesquisarProdutoPorNome(txtNomeProduto.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void PDVForm_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            using (SqlConnection connection = dbConnection.AbrirConexao())
            {
                string query = "SELECT id, nome FROM Clientes";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable clienteTable = new DataTable();
                clienteTable.Load(reader);
                cmbClientes.DataSource = clienteTable;
                cmbClientes.DisplayMember = "nome";
                cmbClientes.ValueMember = "id";
                dbConnection.FecharConexao();
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedItem != null)
            {
                DataRowView rowView = cmbClientes.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    clienteId = Convert.ToInt32(rowView["id"]);
                }
            }
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

            if (!int.TryParse(codigoProduto, out int codigoProdutoInt))
            {
                MessageBox.Show("Código do produto deve ser um número.");
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

            if (!clienteId.HasValue)
            {
                MessageBox.Show("Nenhum cliente selecionado.");
                return;
            }

            if (cmbFormaPagamento.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione a forma de pagamento.");
                return;
            }

            if (cmbFormaPagamento.SelectedItem.ToString() == "Dinheiro" && string.IsNullOrEmpty(txtValorRecebido.Text))
            {
                MessageBox.Show("Por favor, insira o valor recebido.");
                return;
            }

            using (SqlConnection connection = dbConnection.AbrirConexao())
            {
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Insere a venda e obtém o id da venda
                    string query = "INSERT INTO Vendas (id_cliente, data_venda, total, forma_pagamento) OUTPUT INSERTED.id VALUES (@IdCliente, @Data, @Total, @FormaPagamento)";
                    SqlCommand command = new SqlCommand(query, connection, transaction);
                    command.Parameters.AddWithValue("@IdCliente", clienteId.Value);
                    command.Parameters.AddWithValue("@Data", DateTime.Now);
                    command.Parameters.AddWithValue("@Total", decimal.Parse(txtTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture));
                    command.Parameters.AddWithValue("@FormaPagamento", cmbFormaPagamento.SelectedItem.ToString());
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
                    string recibo = GerarRecibo();
                    MessageBox.Show(recibo, "Recibo");
                    dataTable.Clear();
                    AtualizarTotal();
                    LimparCampos();
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
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCodigoProduto.Clear();
            txtNomeProduto.Clear();
            cmbFormaPagamento.SelectedIndex = -1;
            txtValorRecebido.Clear();
            txtTroco.Clear();
        }

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            if (cmbFormaPagamento.SelectedItem != null && cmbFormaPagamento.SelectedItem.ToString() == "Dinheiro")
            {
                if (decimal.TryParse(txtValorRecebido.Text, out decimal valorRecebido))
                {
                    decimal total = decimal.Parse(txtTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
                    decimal troco = valorRecebido - total;
                    txtTroco.Text = troco > 0 ? troco.ToString("C") : "0,00";
                }
                else
                {
                    txtTroco.Text = "0,00";
                }
            }
        }

        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaPagamento.SelectedItem != null && cmbFormaPagamento.SelectedItem.ToString() == "Dinheiro")
            {
                lblValorRecebido.Visible = true;
                txtValorRecebido.Visible = true;
                lblTroco.Visible = true;
                txtTroco.Visible = true;
            }
            else
            {
                lblValorRecebido.Visible = false;
                txtValorRecebido.Visible = false;
                lblTroco.Visible = false;
                txtTroco.Visible = false;
            }
        }

        private void btnGerarRecibo_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto adicionado.");
                return;
            }

            if (!clienteId.HasValue)
            {
                MessageBox.Show("Nenhum cliente selecionado.");
                return;
            }

            string recibo = GerarRecibo();
            MessageBox.Show(recibo, "Recibo");
        }

        private string GerarRecibo()
        {
            string recibo = "Recibo de Venda\n";
            recibo += "-----------------------------\n";
            recibo += $"Cliente: {cmbClientes.Text}\n";
            recibo += $"Data: {DateTime.Now}\n";
            recibo += "-----------------------------\n";
            recibo += "Produtos:\n";

            foreach (DataRow row in dataTable.Rows)
            {
                recibo += $"{row["Produto"]} - {row["Quantidade"]} x {row["Preço Unitário"]:C} = {row["Total"]:C}\n";
            }

            recibo += "-----------------------------\n";
            recibo += $"Total: {txtTotal.Text}\n";
            recibo += $"Forma de Pagamento: {cmbFormaPagamento.SelectedItem}\n";

            if (cmbFormaPagamento.SelectedItem != null && cmbFormaPagamento.SelectedItem.ToString() == "Dinheiro")
            {
                recibo += $"Valor Recebido: {txtValorRecebido.Text}\n";
                recibo += $"Troco: {txtTroco.Text}\n";
            }

            recibo += "-----------------------------\n";
            recibo += "Obrigado pela sua compra!\n";

            return recibo;
        }


        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigoProduto_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeProduto_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigoProduto_Click_1(object sender, EventArgs e)
        {

        }

        private void lblNomeCliente_Click_1(object sender, EventArgs e)
        {

        }

        private void lblNomeProduto_Click_1(object sender, EventArgs e)
        {

        }

        private void lblFormaPagamento_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click_1(object sender, EventArgs e)
        {

        }

        private void lblValorRecebido_Click(object sender, EventArgs e)
        {

        }

        private void lblTroco_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
