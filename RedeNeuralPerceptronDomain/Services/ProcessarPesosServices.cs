using RedeNeuralPerceptronDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeNeuralPerceptronDomain.Services
{
    public class ProcessarPesosServices : IProcessarPesosServices
    {
        public DataRow GerarPesos(DataRow LinhadadosGridPrincipal, DataRow linhadadosGridPesos,double taxaAprendizagem)
        {
            //formula Wi(peso novo)=Wi(peso Antigo)+n(taxa de aprendizagem)*(Saida - resultado)*Xi(entrada antigo)
            DataTable dataTable = new DataTable();
            DataRow novoPeso = dataTable.NewRow();
            if (LinhadadosGridPrincipal.Table.Rows.Count > 0 && linhadadosGridPesos.Table.Rows.Count > 0)
            {
                for (int i = 0; i < linhadadosGridPesos.Table.Columns.Count; i++)
                {
                    dataTable.Columns.Add("Peso" + i, typeof(Int64));
                    novoPeso[i] = Convert.ToDouble(linhadadosGridPesos[i].ToString()) + taxaAprendizagem
                    *(Convert.ToDouble(LinhadadosGridPrincipal["Saida-Result"].ToString()))
                    * (Convert.ToDouble(LinhadadosGridPrincipal[i].ToString()));
                   
                }
                dataTable.Rows.Add(novoPeso);
            }
                   
           return novoPeso;
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
                    dataTablePesos.Columns.Add("Peso" + i, typeof(Int64));
                   
                    linha["Peso" + i] = numeroAleatorio.NextDouble();
                }
                
                dataTablePesos.Rows.Add(linha);
            }
            return dataTablePesos;
        }
    }
}
