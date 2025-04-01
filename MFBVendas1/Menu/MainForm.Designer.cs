namespace SistemaDeVendasMFB
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGerenciarClientes;
        private System.Windows.Forms.Button btnGerenciarProdutos;
        private System.Windows.Forms.Button btnPDV;
        private System.Windows.Forms.Button btnRelatorioVendas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContent;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRelatorioVendas = new System.Windows.Forms.Button();
            this.btnGerenciarClientes = new System.Windows.Forms.Button();
            this.btnGerenciarProdutos = new System.Windows.Forms.Button();
            this.btnPDV = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Navy;
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(784, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(385, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Vendas MFB";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContent.BackgroundImage")));
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelContent.Controls.Add(this.btnSair);
            this.panelContent.Controls.Add(this.btnRelatorioVendas);
            this.panelContent.Controls.Add(this.btnGerenciarClientes);
            this.panelContent.Controls.Add(this.btnGerenciarProdutos);
            this.panelContent.Controls.Add(this.btnPDV);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 60);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(784, 401);
            this.panelContent.TabIndex = 1;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Navy;
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(19, 243);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 50);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRelatorioVendas
            // 
            this.btnRelatorioVendas.BackColor = System.Drawing.Color.Navy;
            this.btnRelatorioVendas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioVendas.ForeColor = System.Drawing.Color.White;
            this.btnRelatorioVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorioVendas.Image")));
            this.btnRelatorioVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelatorioVendas.Location = new System.Drawing.Point(19, 187);
            this.btnRelatorioVendas.Name = "btnRelatorioVendas";
            this.btnRelatorioVendas.Size = new System.Drawing.Size(224, 50);
            this.btnRelatorioVendas.TabIndex = 3;
            this.btnRelatorioVendas.Text = "Relatório de Vendas";
            this.btnRelatorioVendas.UseVisualStyleBackColor = false;
            this.btnRelatorioVendas.Click += new System.EventHandler(this.btnRelatorioVendas_Click);
            // 
            // btnGerenciarClientes
            // 
            this.btnGerenciarClientes.BackColor = System.Drawing.Color.Navy;
            this.btnGerenciarClientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarClientes.ForeColor = System.Drawing.Color.White;
            this.btnGerenciarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnGerenciarClientes.Image")));
            this.btnGerenciarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerenciarClientes.Location = new System.Drawing.Point(19, 19);
            this.btnGerenciarClientes.Name = "btnGerenciarClientes";
            this.btnGerenciarClientes.Size = new System.Drawing.Size(224, 50);
            this.btnGerenciarClientes.TabIndex = 0;
            this.btnGerenciarClientes.Text = "Gerenciar Clientes";
            this.btnGerenciarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerenciarClientes.UseVisualStyleBackColor = false;
            this.btnGerenciarClientes.Click += new System.EventHandler(this.btnGerenciarClientes_Click);
            // 
            // btnGerenciarProdutos
            // 
            this.btnGerenciarProdutos.BackColor = System.Drawing.Color.Navy;
            this.btnGerenciarProdutos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarProdutos.ForeColor = System.Drawing.Color.White;
            this.btnGerenciarProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnGerenciarProdutos.Image")));
            this.btnGerenciarProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerenciarProdutos.Location = new System.Drawing.Point(19, 75);
            this.btnGerenciarProdutos.Name = "btnGerenciarProdutos";
            this.btnGerenciarProdutos.Size = new System.Drawing.Size(224, 50);
            this.btnGerenciarProdutos.TabIndex = 1;
            this.btnGerenciarProdutos.Text = "Gerenciar Produtos";
            this.btnGerenciarProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerenciarProdutos.UseVisualStyleBackColor = false;
            this.btnGerenciarProdutos.Click += new System.EventHandler(this.btnGerenciarProdutos_Click);
            // 
            // btnPDV
            // 
            this.btnPDV.BackColor = System.Drawing.Color.Navy;
            this.btnPDV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDV.ForeColor = System.Drawing.Color.White;
            this.btnPDV.Image = ((System.Drawing.Image)(resources.GetObject("btnPDV.Image")));
            this.btnPDV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDV.Location = new System.Drawing.Point(19, 131);
            this.btnPDV.Name = "btnPDV";
            this.btnPDV.Size = new System.Drawing.Size(224, 50);
            this.btnPDV.TabIndex = 2;
            this.btnPDV.Text = "PDV";
            this.btnPDV.UseVisualStyleBackColor = false;
            this.btnPDV.Click += new System.EventHandler(this.btnPDV_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}


