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
        DataTable Somatorio(DataTable dadosGridPrincipal, DataTable dadosGridPesos, double taxaAprendizagem);

        Int64 FuncaoAtivao(double Somatoria);
    }
}
