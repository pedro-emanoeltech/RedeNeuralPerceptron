using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeNeuralPerceptronDomain.Interfaces.Services
{
    public interface IProcessarPesosServices
    {
        DataTable GerarGridValoresPesosInicias(DataTable dadosGridPrincipal);
        void GerarPesos(DataRow LinhadadosGridPrincipal, DataTable dadosGridPesos, double taxaAprendizagem);
    }
}
