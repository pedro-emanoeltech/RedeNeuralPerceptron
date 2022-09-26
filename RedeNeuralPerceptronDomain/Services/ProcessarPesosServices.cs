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
        public DataTable GerarPesos(DataTable dadosGridPrincipal, DataTable dadosGridPesos,int taxaAprendizagem,int result)
        {
            if (dadosGridPrincipal.Rows.Count > 0 && dadosGridPesos.Rows.Count > 0)
            {
                for (int i = 1; i < dadosGridPrincipal.Columns.Count; i++)
                {
                    for (int j = 1; i < dadosGridPesos.Columns.Count; i++)
                    {
                        DataTable novoPeso = new DataTable();
                        var valor = Convert.ToInt64 (dadosGridPesos.Rows[i][j]) + taxaAprendizagem * Convert.ToInt64(dadosGridPrincipal.Rows[i][j]);
                    }
                }
                
            }
           return dadosGridPrincipal;
        }

        public DataTable GerarGridValoresPesosInicias(DataTable dadosGridPrincipal)
        {
            DataTable dataTablePesos = new DataTable();
            Random numeroAleatorio = new Random();
            if (dadosGridPrincipal.Columns.Count > 0)
            {
                DataRow linha = dataTablePesos.NewRow();
                for (int i = 0; i < dadosGridPrincipal.Columns.Count-1; i++)
                {
                    dataTablePesos.Columns.Add("Peso" + i, typeof(Int64));
                   
                    linha["Peso" + i] = numeroAleatorio.NextDouble();
                }
                dataTablePesos.Columns.Add("∑", typeof(Int64));
                dataTablePesos.Rows.Add(linha);
            }
            return dataTablePesos;
        }
    }
}
