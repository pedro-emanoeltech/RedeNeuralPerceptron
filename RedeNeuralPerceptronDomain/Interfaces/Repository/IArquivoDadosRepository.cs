using RedeNeuralPerceptronDomain.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeNeuralPerceptronDomain.Interfaces.Repository
{
    public interface IArquivoDadosRepository
    {
        DataTable CarregarArquivo(ArquivoDados arquivoDados);
    }
}
