namespace SistemaDeVendasMFB
{
    partial class RelatorioVendasForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.DataGridView dataGridViewRelatorio;
        private System.Windows.Forms.ComboBox cmbTipoRelatorio;
        private System.Windows.Forms.Label lblTipoRelatorio;
        private System.Windows.Forms.Button btnExportar;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioVendasForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.dataGridViewRelatorio = new System.Windows.Forms.DataGridView();
            this.cmbTipoRelatorio = new System.Windows.Forms.ComboBox();
            this.lblTipoRelatorio = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(16, 18);
            this.lblDataInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(70, 16);
            this.lblDataInicio.TabIndex = 0;
            this.lblDataInicio.Text = "Data Início";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Location = new System.Drawing.Point(101, 15);
            this.dtpDataInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(265, 22);
            this.dtpDataInicio.TabIndex = 1;
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(376, 18);
            this.lblDataFim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(61, 16);
            this.lblDataFim.TabIndex = 2;
            this.lblDataFim.Text = "Data Fim";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Location = new System.Drawing.Point(452, 15);
            this.dtpDataFim.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(265, 22);
            this.dtpDataFim.TabIndex = 3;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarRelatorio.Image")));
            this.btnGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(595, 596);
            this.btnGerarRelatorio.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(122, 51);
            this.btnGerarRelatorio.TabIndex = 4;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // dataGridViewRelatorio
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRelatorio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatorio.Location = new System.Drawing.Point(19, 84);
            this.dataGridViewRelatorio.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRelatorio.Name = "dataGridViewRelatorio";
            this.dataGridViewRelatorio.Size = new System.Drawing.Size(698, 492);
            this.dataGridViewRelatorio.TabIndex = 5;
            this.dataGridViewRelatorio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRelatorio_CellContentClick);
            // 
            // cmbTipoRelatorio
            // 
            this.cmbTipoRelatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoRelatorio.FormattingEnabled = true;
            this.cmbTipoRelatorio.Items.AddRange(new object[] {
            "Produtos Vendidos",
            "Produtos Vendidos por Cliente"});
            this.cmbTipoRelatorio.Location = new System.Drawing.Point(121, 47);
            this.cmbTipoRelatorio.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoRelatorio.Name = "cmbTipoRelatorio";
            this.cmbTipoRelatorio.Size = new System.Drawing.Size(265, 24);
            this.cmbTipoRelatorio.TabIndex = 6;
            // 
            // lblTipoRelatorio
            // 
            this.lblTipoRelatorio.AutoSize = true;
            this.lblTipoRelatorio.Location = new System.Drawing.Point(16, 50);
            this.lblTipoRelatorio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoRelatorio.Name = "lblTipoRelatorio";
            this.lblTipoRelatorio.Size = new System.Drawing.Size(93, 16);
            this.lblTipoRelatorio.TabIndex = 7;
            this.lblTipoRelatorio.Text = "Tipo Relatório";
            // 
            // btnExportar
            // 
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.Location = new System.Drawing.Point(9, 596);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(122, 51);
            this.btnExportar.TabIndex = 8;
            this.btnExportar.TabStop = false;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // RelatorioVendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 690);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lblTipoRelatorio);
            this.Controls.Add(this.cmbTipoRelatorio);
            this.Controls.Add(this.dataGridViewRelatorio);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.dtpDataFim);
            this.Controls.Add(this.lblDataFim);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.lblDataInicio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RelatorioVendasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.RelatorioVendasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

