﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

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
                    query = "SELECT p.codigo, p.nome, iv.quantidade, iv.preco_unitario, iv.subtotal, v.forma_pagamento " +
                            "FROM ItensVenda iv " +
                            "JOIN Produtos p ON iv.id_produto = p.codigo " +
                            "JOIN Vendas v ON iv.id_venda = v.id " +
                            "WHERE CAST(v.data_venda AS DATE) BETWEEN @DataInicio AND @DataFim";
                    break;
                case "Produtos Vendidos por Cliente":
                    query = "SELECT c.nome AS Cliente, p.codigo, p.nome, iv.quantidade, iv.preco_unitario, iv.subtotal, v.forma_pagamento " +
                            "FROM ItensVenda iv " +
                            "JOIN Produtos p ON iv.id_produto = p.codigo " +
                            "JOIN Vendas v ON iv.id_venda = v.id " +
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
                        FormatarDataGridView();
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

        private void FormatarDataGridView()
        {
            dataGridViewRelatorio.Columns["codigo"].HeaderText = "Código";
            dataGridViewRelatorio.Columns["nome"].HeaderText = "Nome";
            dataGridViewRelatorio.Columns["quantidade"].HeaderText = "Quantidade";
           
            dataGridViewRelatorio.Columns["forma_pagamento"].HeaderText = "Forma de Pagamento";
            dataGridViewRelatorio.Columns["subtotal"].HeaderText = "Subtotal";

            dataGridViewRelatorio.Columns["preco_unitario"].DefaultCellStyle.Format = "C2";
            dataGridViewRelatorio.Columns["subtotal"].DefaultCellStyle.Format = "C2";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dataGridViewRelatorio.DataSource == null)
            {
                MessageBox.Show("Nenhum dado para exportar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.Title = "Salvar Relatório";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Escrever cabeçalhos
                        for (int i = 0; i < dataGridViewRelatorio.Columns.Count; i++)
                        {
                            writer.Write(dataGridViewRelatorio.Columns[i].HeaderText);
                            if (i < dataGridViewRelatorio.Columns.Count - 1)
                            {
                                writer.Write(",");
                            }
                        }
                        writer.WriteLine();

                        // Escrever dados
                        foreach (DataGridViewRow row in dataGridViewRelatorio.Rows)
                        {
                            for (int i = 0; i < dataGridViewRelatorio.Columns.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value);
                                if (i < dataGridViewRelatorio.Columns.Count - 1)
                                {
                                    writer.Write(",");
                                }
                            }
                            writer.WriteLine();
                        }
                    }
                    MessageBox.Show("Relatório exportado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exportar o relatório: " + ex.Message);
                }
            }
        }
    }
}

