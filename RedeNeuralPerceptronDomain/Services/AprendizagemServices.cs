using RedeNeuralPerceptronDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeNeuralPerceptronDomain.Services
{
    public class AprendizagemServices: IAprendizagemServices
    {
        public int Somatorio(DataTable dadosGridPrincipal, DataTable dadosGridPesos, int taxaAprendizagem,int linha)
        {
            long valor = 0;
            for (int i = 0; i < dadosGridPrincipal.Columns.Count - 3; i++)
            {
                DataTable novoPeso = new DataTable();
                valor = Convert.ToInt64(dadosGridPesos.Rows[i][i]) * Convert.ToInt64(dadosGridPrincipal.Rows[i][i]);
                valor = +valor;
            }
            var valorComBias = valor+ taxaAprendizagem;
            if (valorComBias >= 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }  
        }


    }
}
