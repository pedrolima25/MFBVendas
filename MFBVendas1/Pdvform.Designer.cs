namespace SistemaDeVendasMFB
{
    partial class PDVForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.lblCodigoProduto, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtCodigoProduto, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.btnAdicionarProduto, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewProdutos, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.lblTotal, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.txtTotal, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.btnFinalizarVenda, 2, 5);
            this.tableLayoutPanel.Controls.Add(this.btnCancelarVenda, 2, 6);
            this.tableLayoutPanel.Controls.Add(this.lblNomeProduto, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.txtNomeProduto, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.btnPesquisarProduto, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.lblNomeCliente, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.cmbClientes, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(60, 57);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(97, 13);
            this.lblCodigoProduto.TabIndex = 0;
            this.lblCodigoProduto.Text = "Código do Produto:";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigoProduto.Location = new System.Drawing.Point(163, 54);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(474, 20);
            this.txtCodigoProduto.TabIndex = 1;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(643, 52);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarProduto.TabIndex = 2;
            this.btnAdicionarProduto.Text = "Adicionar";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel.SetColumnSpan(this.dataGridViewProdutos, 3);
            this.dataGridViewProdutos.Location = new System.Drawing.Point(100, 183);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(600, 174);
            this.dataGridViewProdutos.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(122, 363);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTotal.Location = new System.Drawing.Point(163, 360);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(474, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(643, 358);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizarVenda.TabIndex = 6;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelarVenda.Location = new System.Drawing.Point(643, 408);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarVenda.TabIndex = 7;
            this.btnCancelarVenda.Text = "Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(60, 102);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(97, 13);
            this.lblNomeProduto.TabIndex = 8;
            this.lblNomeProduto.Text = "Nome do Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNomeProduto.Location = new System.Drawing.Point(163, 99);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(474, 20);
            this.txtNomeProduto.TabIndex = 9;
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(643, 97);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarProduto.TabIndex = 10;
            this.btnPesquisarProduto.Text = "Pesquisar";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(70, 12);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(87, 13);
            this.lblNomeCliente.TabIndex = 11;
            this.lblNomeCliente.Text = "Nome do Cliente:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(163, 8);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(474, 21);
            this.cmbClientes.TabIndex = 12;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // PDVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "PDVForm";
            this.Text = "PDV";
            this.Load += new System.EventHandler(this.PDVForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

