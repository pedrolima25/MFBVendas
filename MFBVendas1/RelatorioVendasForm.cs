using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaDeVendasMFB
{
    public partial class RelatorioVendasForm : Form
    {
        private Conexao dbConnection;

        public RelatorioVendasForm()
        {
            InitializeComponent();
            dbConnection = new Conexao();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            if (cmbTipoRelatorio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione o tipo de relatório.");
                return;
            }

            DateTime dataInicio = dtpDataInicio.Value.Date;
            DateTime dataFim = dtpDataFim.Value.Date;

            string query = string.Empty;

            switch (cmbTipoRelatorio.SelectedItem.ToString())
            {
                case "Produtos Vendidos":
                    query = "SELECT p.codigo, p.nome, iv.quantidade, iv.preco_unitario, iv.subtotal " +
                            "FROM ItensVenda iv " +
                            "JOIN Produtos p ON iv.id_produto = p.codigo " +
                            "JOIN Vendas v ON iv.id_venda = v.id " +
                            "WHERE CAST(v.data_venda AS DATE) BETWEEN @DataInicio AND @DataFim";
                    break;
                case "Produtos Vendidos por Cliente":
                    query = "SELECT c.nome AS Cliente, p.codigo, p.nome, iv.quantidade, iv.preco_unitario, iv.subtotal " +
                            "FROM ItensVenda iv " +
                            "JOIN Produtos p ON iv.id_produto = p.codigo " +
                            "JOIN Vendas v ON iv.id_venda = v.id " +
                            "JOIN Clientes c ON v.id_cliente = c.id " +
                            "WHERE CAST(v.data_venda AS DATE) BETWEEN @DataInicio AND @DataFim";
                    break;
                case "Vendas Realizadas aos Clientes":
                    query = "SELECT v.id, c.nome AS Cliente, v.data_venda, v.total " +
                            "FROM Vendas v " +
                            "JOIN Clientes c ON v.id_cliente = c.id " +
                            "WHERE CAST(v.data_venda AS DATE) BETWEEN @DataInicio AND @DataFim";
                    break;
            }

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Erro ao gerar a consulta SQL.");
                return;
            }

            try
            {
                using (SqlConnection connection = dbConnection.AbrirConexao())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DataInicio", dataInicio);
                    command.Parameters.AddWithValue("@DataFim", dataFim);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum dado encontrado para o período selecionado.");
                    }
                    else
                    {
                        dataGridViewRelatorio.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o relatório: " + ex.Message);
            }
            finally
            {
                dbConnection.FecharConexao();
            }
        }
    }
}

