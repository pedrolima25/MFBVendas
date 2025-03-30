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

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            ListaProdutosForm listaProdutosForm = new ListaProdutosForm();
            listaProdutosForm.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ListaClientesForm listaClientesForm = new ListaClientesForm();
            listaClientesForm.Show();
        }
    }
}