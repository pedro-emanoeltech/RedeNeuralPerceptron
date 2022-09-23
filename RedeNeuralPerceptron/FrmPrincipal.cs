
using RedeNeuralPerceptronDomain.Entity;
using RedeNeuralPerceptronDomain.Services;
using System;
using System.Windows.Forms;


namespace RedeNeuralPerceptron
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarArquivo_Click(object sender, EventArgs e)
        {            
            ProcessarArquivoServices processarArquivoServices = new ProcessarArquivoServices();
            var arquivoDados = processarArquivoServices.BuscarArquivo();
            if (!String.IsNullOrEmpty(arquivoDados.Caminho))
            {
                CaminhoArquivoTextBox.Text = arquivoDados.Caminho.ToString();
                DGDados.DataSource = processarArquivoServices.CarregarArquivo(arquivoDados);


            }
         


        }
    }
}
