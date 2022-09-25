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
        DataTable GerarGridValores(DataTable dadosGridPrincipal);
        DataTable GerarPesos(DataTable dadosGridPrincipal);
    }
}
