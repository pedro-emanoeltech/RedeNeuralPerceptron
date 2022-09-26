using RedeNeuralPerceptronDomain.Interfaces.Services;
using RedeNeuralPerceptronDomain.Services;
using System;
using System.Data;
using System.Windows.Forms;


namespace RedeNeuralPerceptron
{
    public partial class FrmPrincipal : Form
    {
        private readonly IProcessarArquivoServices _processarArquivoServices;
        private readonly IProcessarPesosServices _processarPesosServices;
        private readonly IAprendizagemServices _aprendizagemServices;
        public FrmPrincipal(IProcessarArquivoServices processarArquivoServices, IProcessarPesosServices processarPesosServices, IAprendizagemServices aprendizagemServices)
        {
            _processarArquivoServices = processarArquivoServices;
            _processarPesosServices = processarPesosServices;
            _aprendizagemServices = aprendizagemServices;
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
                dadosEntrada.Columns.Add("Resultado", typeof(Int64));
                dadosEntrada.Columns.Add("SAIDA-RESULTADO", typeof(Int64));


                if (dadosEntrada != null)
                    DadosGridView.DataSource = dadosEntrada;
                var dadosPesos = _processarPesosServices.GerarGridValoresPesosInicias(dadosEntrada);
                PesosGridView.DataSource = dadosPesos;

                //DataRow linha = dadosEntrada.row[]
                for (int i = 0; i < dadosEntrada.Rows.Count; i++)
                {
                    DataRow linha = dadosEntrada.Rows[i];
                    //linha["Resultado"] = _aprendizagemServices.Somatorio(dadosEntrada, dadosPesos, int.Parse(BiasTextBox.Text),i);
                }
                
            }



        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }


    }
}
