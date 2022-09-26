using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeNeuralPerceptronDomain.Interfaces.Services
{
    public interface IAprendizagemServices
    {
        int Somatorio(DataTable dadosGridPrincipal, DataTable dadosGridPesos, int taxaAprendizagem, int linha);
    }
}
