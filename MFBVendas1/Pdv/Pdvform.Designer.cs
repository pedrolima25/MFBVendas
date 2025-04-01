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
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private System.Windows.Forms.Label lblValorRecebido;
        private System.Windows.Forms.TextBox txtValorRecebido;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Button btnGerarRecibo;

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
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lblValorRecebido = new System.Windows.Forms.Label();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.btnGerarRecibo = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
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
            this.tableLayoutPanel.Controls.Add(this.lblFormaPagamento, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.cmbFormaPagamento, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lblValorRecebido, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.txtValorRecebido, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.lblTroco, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.txtTroco, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.btnGerarRecibo, 2, 7);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 500);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProduto.Location = new System.Drawing.Point(28, 67);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(129, 16);
            this.lblCodigoProduto.TabIndex = 0;
            this.lblCodigoProduto.Text = "Código do Produto:";
            this.lblCodigoProduto.Click += new System.EventHandler(this.lblCodigoProduto_Click_1);
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigoProduto.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProduto.Location = new System.Drawing.Point(163, 63);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(285, 24);
            this.txtCodigoProduto.TabIndex = 1;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdicionarProduto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdicionarProduto.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProduto.ImageKey = "(nenhum/a)";
            this.btnAdicionarProduto.Location = new System.Drawing.Point(463, 63);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionarProduto.TabIndex = 2;
            this.btnAdicionarProduto.Text = "Adicionar";
            this.btnAdicionarProduto.UseVisualStyleBackColor = false;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel.SetColumnSpan(this.dataGridViewProdutos, 3);
            this.dataGridViewProdutos.Location = new System.Drawing.Point(100, 203);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(600, 144);
            this.dataGridViewProdutos.TabIndex = 3;
            this.dataGridViewProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellContentClick);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(114, 367);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 16);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click_1);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(163, 357);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(201, 36);
            this.txtTotal.TabIndex = 5;
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(463, 363);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(100, 23);
            this.btnFinalizarVenda.TabIndex = 6;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelarVenda.Location = new System.Drawing.Point(463, 413);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(100, 23);
            this.btnCancelarVenda.TabIndex = 7;
            this.btnCancelarVenda.Text = "Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(35, 117);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(122, 16);
            this.lblNomeProduto.TabIndex = 8;
            this.lblNomeProduto.Text = "Nome do Produto:";
            this.lblNomeProduto.Click += new System.EventHandler(this.lblNomeProduto_Click_1);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNomeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNomeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(163, 113);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(285, 24);
            this.txtNomeProduto.TabIndex = 9;
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPesquisarProduto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPesquisarProduto.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarProduto.ImageKey = "(nenhum/a)";
            this.btnPesquisarProduto.Location = new System.Drawing.Point(463, 113);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(100, 23);
            this.btnPesquisarProduto.TabIndex = 10;
            this.btnPesquisarProduto.Text = "Pesquisar";
            this.btnPesquisarProduto.UseVisualStyleBackColor = false;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(42, 17);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(115, 16);
            this.lblNomeCliente.TabIndex = 11;
            this.lblNomeCliente.Text = "Nome do Cliente:";
            this.lblNomeCliente.Click += new System.EventHandler(this.lblNomeCliente_Click_1);
            // 
            // cmbClientes
            // 
            this.cmbClientes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClientes.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(163, 13);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(235, 24);
            this.cmbClientes.TabIndex = 12;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPagamento.Location = new System.Drawing.Point(14, 167);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(143, 16);
            this.lblFormaPagamento.TabIndex = 13;
            this.lblFormaPagamento.Text = "Forma de Pagamento:";
            this.lblFormaPagamento.Click += new System.EventHandler(this.lblFormaPagamento_Click);
            // 
            // cmbFormaPagamento
            // 
            this.cmbFormaPagamento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPagamento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão",
            "Pix"});
            this.cmbFormaPagamento.Location = new System.Drawing.Point(163, 163);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(181, 24);
            this.cmbFormaPagamento.TabIndex = 14;
            this.cmbFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPagamento_SelectedIndexChanged);
            // 
            // lblValorRecebido
            // 
            this.lblValorRecebido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValorRecebido.AutoSize = true;
            this.lblValorRecebido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorRecebido.Location = new System.Drawing.Point(53, 417);
            this.lblValorRecebido.Name = "lblValorRecebido";
            this.lblValorRecebido.Size = new System.Drawing.Size(104, 16);
            this.lblValorRecebido.TabIndex = 15;
            this.lblValorRecebido.Text = "Valor Recebido:";
            this.lblValorRecebido.Click += new System.EventHandler(this.lblValorRecebido_Click);
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtValorRecebido.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorRecebido.Location = new System.Drawing.Point(163, 407);
            this.txtValorRecebido.Multiline = true;
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(201, 36);
            this.txtValorRecebido.TabIndex = 16;
            this.txtValorRecebido.TextChanged += new System.EventHandler(this.txtValorRecebido_TextChanged);
            // 
            // lblTroco
            // 
            this.lblTroco.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(111, 467);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(46, 16);
            this.lblTroco.TabIndex = 17;
            this.lblTroco.Text = "Troco:";
            this.lblTroco.Click += new System.EventHandler(this.lblTroco_Click);
            // 
            // txtTroco
            // 
            this.txtTroco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(163, 457);
            this.txtTroco.Multiline = true;
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(201, 35);
            this.txtTroco.TabIndex = 18;
            // 
            // btnGerarRecibo
            // 
            this.btnGerarRecibo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGerarRecibo.Location = new System.Drawing.Point(463, 463);
            this.btnGerarRecibo.Name = "btnGerarRecibo";
            this.btnGerarRecibo.Size = new System.Drawing.Size(100, 23);
            this.btnGerarRecibo.TabIndex = 19;
            this.btnGerarRecibo.Text = "Gerar Recibo";
            this.btnGerarRecibo.UseVisualStyleBackColor = true;
            this.btnGerarRecibo.Click += new System.EventHandler(this.btnGerarRecibo_Click);
            // 
            // PDVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "PDVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV";
            this.Load += new System.EventHandler(this.PDVForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

