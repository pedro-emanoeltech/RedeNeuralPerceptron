using RedeNeuralPerceptronDomain.Interfaces.Services;
using RedeNeuralPerceptronDomain.Services;
using System;
using System.Windows.Forms;


namespace RedeNeuralPerceptron
{
    public partial class FrmPrincipal : Form
    {
        private readonly IProcessarArquivoServices _processarArquivoServices;
        private readonly IProcessarPesosServices _processarPesosServices;
        public FrmPrincipal(IProcessarArquivoServices processarArquivoServices,IProcessarPesosServices processarPesosServices )
        {
          _processarArquivoServices = processarArquivoServices;
          _processarPesosServices = processarPesosServices;
           InitializeComponent();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarArquivo_Click(object sender, EventArgs e)
        {            
            
            var arquivoDados = _processarArquivoServices.BuscarArquivo();
            if (!String.IsNullOrEmpty(arquivoDados.Caminho))
            {
                CaminhoArquivoTextBox.Text = arquivoDados.Caminho.ToString();
                var dadosEntrada = _processarArquivoServices.CarregarArquivo(arquivoDados);


                if (dadosEntrada != null)
                DadosGridView.DataSource = dadosEntrada;
                PesosGridView.DataSource = _processarPesosServices.GerarGridValores(dadosEntrada);
            }

           

        }

        
    }
}
