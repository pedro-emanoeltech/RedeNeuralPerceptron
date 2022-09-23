using RedeNeuralPerceptronDomain.Entity;
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
            OpenFileDialog caminhoArquivo = new OpenFileDialog
            {
                Title = "Procurar Arquivos de Texto",
                Filter = "arquivos txt (*.txt)|*.txt",
                CheckFileExists = true,
                CheckPathExists = true
            };
            caminhoArquivo.ShowDialog();
            CaminhoArquivoTextBox.Text = caminhoArquivo.FileName;
            ArquivoDados arquivoDados = new ArquivoDados();
            arquivoDados.Endereco = caminhoArquivo.FileName;
        }
    }
}
