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
            ListaClientesForm listaClientesForm = new ListaClientesForm();
            listaClientesForm.Show();
        }

        private void btnGerenciarProdutos_Click(object sender, EventArgs e)
        {
            ListaProdutosForm listaProdutosForm = new ListaProdutosForm();
            listaProdutosForm.Show();
        }

        private void btnPDV_Click(object sender, EventArgs e)
        {
            PDVForm pdvForm = new PDVForm();
            pdvForm.Show();
        }
    }
}