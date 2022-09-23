using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using RedeNeuralPerceptronDomain.Entity;
using System.Collections;
using System.IO;
using static RedeNeuralPerceptronDomain.Commons.Enums;
using System.Data;

namespace RedeNeuralPerceptronDomain.Services
{
    public class ProcessarArquivoServices
    {
        public ArquivoDados BuscarArquivo()
        {
            ArquivoDados arquivoDados = new ArquivoDados();
            OpenFileDialog caminhoArquivo = new OpenFileDialog
            {
                Title = "Procurar Arquivos de Texto",
                Filter = "arquivos Execel (*.xlsx;*.xls)|*.xlsx;*.xls",
               
                CheckFileExists = true,
                CheckPathExists = true
            };
            caminhoArquivo.ShowDialog();
           
            if (caminhoArquivo.FileName.Length > 0 )
            {
                arquivoDados.Caminho = caminhoArquivo.FileName;
                arquivoDados.Tipo = Path.GetExtension(caminhoArquivo.FileName);
                arquivoDados.Nome= caminhoArquivo.SafeFileName;

                return arquivoDados;
            }
            return arquivoDados;
        }
        public DataTable CarregarArquivo(ArquivoDados arquivoDados)
        {
            var caminhoCompleto = "@"+arquivoDados.Caminho;
            var selectPlanilha = "SELECT *FROM [DADOS$]";
            var conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + caminhoCompleto +
                ";Extended Properties=\"Excel 12.0;HDR = yes;IMEX=0\"";

            var dadosExcel = new DataTable();

            using (OleDbConnection Con =new OleDbConnection(conexao))
            {
                using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(selectPlanilha, Con))
                {
                    dataAdapter.Fill(dadosExcel);
                }
            }
                return dadosExcel;
        }
    }
}
