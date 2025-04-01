using System;
using System.Windows.Forms;

namespace SistemaDeVendasMFB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGerenciarClientes_Click(object sender, EventArgs e)
        {
            CadastroClienteForm cadastroClienteForm = new CadastroClienteForm();
            cadastroClienteForm.Show();
        }

        private void btnGerenciarProdutos_Click(object sender, EventArgs e)
        {
            CadastroProdutoForm cadastroProdutoForm = new CadastroProdutoForm();
            cadastroProdutoForm.Show();
        }

        private void btnPDV_Click(object sender, EventArgs e)
        {
            
            PDVForm pdvForm = new PDVForm();
            pdvForm.Show();
        }

        private void btnRelatorioVendas_Click(object sender, EventArgs e)
        {
            RelatorioVendasForm relatorioVendasForm = new RelatorioVendasForm();
            relatorioVendasForm.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}



