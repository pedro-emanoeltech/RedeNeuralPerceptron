using RedeNeuralPerceptronDomain.Interfaces.Services;
using System;
using System.Data;


namespace RedeNeuralPerceptronDomain.Services
{
    public class ProcessarPesosServices : IProcessarPesosServices
    {
        public void GerarPesos(DataRow LinhadadosGridPrincipal, DataTable dadosGridPesos ,double taxaAprendizagem)
        {
            //formula Wi(peso novo)=Wi(peso Antigo)+n(taxa de aprendizagem)*(Saida - resultado)*Xi(entrada antigo)
            DataRow linhaPesos = dadosGridPesos.NewRow();
            DataRow linhapesosAntiga = dadosGridPesos.Rows[dadosGridPesos.Rows.Count-1];
            if (LinhadadosGridPrincipal.Table.Rows.Count > 0 && dadosGridPesos.Rows.Count > 0)
            {
                for (int i = 0; i < dadosGridPesos.Columns.Count; i++)
                {
                   var v = Convert.ToDouble(LinhadadosGridPrincipal["Saida - Result"]);
                   var t = Convert.ToDouble(LinhadadosGridPrincipal[i]);
                    var j = linhaPesos[i];
                    //dataTable.Columns.Add("Peso(" + i + ')', typeof(double));
                    linhaPesos[i] = Convert.ToDouble(linhapesosAntiga[i].ToString()) + (taxaAprendizagem
                    * ((Convert.ToDouble(LinhadadosGridPrincipal["Saida - Result"].ToString()))
                    * (Convert.ToDouble(LinhadadosGridPrincipal[i].ToString()))));
                    
                }
                var dado = linhaPesos;
                dadosGridPesos.Rows.Add(linhaPesos);
            }
                   
          
        }

        public DataTable GerarGridValoresPesosInicias(DataTable dadosGridPrincipal)
        {
            DataTable dataTablePesos = new DataTable();
            Random numeroAleatorio = new Random();
            if (dadosGridPrincipal.Columns.Count > 0)
            {
                DataRow linha = dataTablePesos.NewRow();
                for (int i = 0; i < dadosGridPrincipal.Columns.Count-4; i++)
                {
                    dataTablePesos.Columns.Add("Peso(" + i+')', typeof(double));

                    linha["Peso(" + i + ')'] = numeroAleatorio.Next(100);
                    
                }
                
                dataTablePesos.Rows.Add(linha);
            }
            return dataTablePesos;
        }
    }
}
