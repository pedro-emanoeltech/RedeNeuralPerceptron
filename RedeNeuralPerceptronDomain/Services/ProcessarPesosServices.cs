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
        public DataTable GerarPesos(DataTable dadosGridPrincipal)
        {
           return dadosGridPrincipal;
        }

        public DataTable GerarGridValores(DataTable dadosGridPrincipal)
        {
            DataTable dataTablePesos = new DataTable();
            if (dadosGridPrincipal.Rows.Count > 0)
            {
                
                for (int i = 1; i < dadosGridPrincipal.Columns.Count; i++)
                {
                    dataTablePesos.Columns.Add("Peso"+i,typeof(Int64));
                }

                dataTablePesos.Columns.Add("∑", typeof(Int64));
            }
            return dataTablePesos;
        }
    }
}
