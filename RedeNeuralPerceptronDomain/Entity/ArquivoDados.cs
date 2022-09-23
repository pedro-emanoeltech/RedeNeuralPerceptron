using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeNeuralPerceptronDomain.Entity
{
    public class ArquivoDados : Base
    {
        public string Nome { set; get; }
        public string Caminho{ set; get; }
        public string Tipo { set; get; }
    }
}
 