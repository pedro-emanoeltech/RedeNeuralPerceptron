using RedeNeuralPerceptronDomain.Entity;
using RedeNeuralPerceptronDomain.Interfaces.Repository;
using System;
using System.Data;
using System.Data.OleDb;


namespace RedeNeuralPerceptronInfras.Service
{
    public class ArquivoDadosRepository : IArquivoDadosRepository
    {

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
                throw new InvalidOperationException("Falha ao carregar arquivo" + e.Message);
            }
        }
    }
}
