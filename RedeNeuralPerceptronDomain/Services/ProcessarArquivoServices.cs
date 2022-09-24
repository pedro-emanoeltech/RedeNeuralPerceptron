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
            try
            {
                OleDbConnection Con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source='" + arquivoDados.Caminho +
                    "'; Extended Properties = 'Excel 12.0 Xml;HDR = yes'");

                Con.Open();
                DataTable table = Con.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables, null
                    );
                Con.Close();

                var selectPlanilha = "SELECT *FROM [" + table.Rows[0]["Table_Name"] + "]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(selectPlanilha, Con);


                DataTable tabelaDados = new DataTable();
                dataAdapter.Fill(tabelaDados);

                return tabelaDados;

            }
            catch (Exception e) 
            {
                throw new InvalidOperationException("Falha ao carregar arquivo"+e.Message);
            }
        }
    }
}
