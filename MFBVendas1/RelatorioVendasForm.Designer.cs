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
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.dataGridViewRelatorio = new System.Windows.Forms.DataGridView();
            this.cmbTipoRelatorio = new System.Windows.Forms.ComboBox();
            this.lblTipoRelatorio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(12, 15);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(58, 13);
            this.lblDataInicio.TabIndex = 0;
            this.lblDataInicio.Text = "Data Início";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Location = new System.Drawing.Point(76, 12);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpDataInicio.TabIndex = 1;
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(282, 15);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(51, 13);
            this.lblDataFim.TabIndex = 2;
            this.lblDataFim.Text = "Data Fim";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Location = new System.Drawing.Point(339, 12);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(200, 20);
            this.dtpDataFim.TabIndex = 3;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(545, 10);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btnGerarRelatorio.TabIndex = 4;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // dataGridViewRelatorio
            // 
            this.dataGridViewRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatorio.Location = new System.Drawing.Point(15, 68);
            this.dataGridViewRelatorio.Name = "dataGridViewRelatorio";
            this.dataGridViewRelatorio.Size = new System.Drawing.Size(600, 200);
            this.dataGridViewRelatorio.TabIndex = 5;
            // 
            // cmbTipoRelatorio
            // 
            this.cmbTipoRelatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoRelatorio.FormattingEnabled = true;
            this.cmbTipoRelatorio.Items.AddRange(new object[] {
            "Produtos Vendidos",
            "Produtos Vendidos por Cliente",
            "Vendas Realizadas aos Clientes"});
            this.cmbTipoRelatorio.Location = new System.Drawing.Point(76, 38);
            this.cmbTipoRelatorio.Name = "cmbTipoRelatorio";
            this.cmbTipoRelatorio.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoRelatorio.TabIndex = 6;
            // 
            // lblTipoRelatorio
            // 
            this.lblTipoRelatorio.AutoSize = true;
            this.lblTipoRelatorio.Location = new System.Drawing.Point(12, 41);
            this.lblTipoRelatorio.Name = "lblTipoRelatorio";
            this.lblTipoRelatorio.Size = new System.Drawing.Size(58, 13);
            this.lblTipoRelatorio.TabIndex = 7;
            this.lblTipoRelatorio.Text = "Tipo Relatório";
            // 
            // RelatorioVendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 281);
            this.Controls.Add(this.lblTipoRelatorio);
            this.Controls.Add(this.cmbTipoRelatorio);
            this.Controls.Add(this.dataGridViewRelatorio);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.dtpDataFim);
            this.Controls.Add(this.lblDataFim);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.lblDataInicio);
            this.Name = "RelatorioVendasForm";
            this.Text = "Relatório de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

