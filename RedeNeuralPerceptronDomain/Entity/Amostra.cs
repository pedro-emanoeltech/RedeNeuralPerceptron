
using System.Collections.Generic;

namespace RedeNeuralPerceptronDomain.Entity
{
    public class Amostra : Base
    {
        public int? QuantidadeAmostra{ set; get; }
        public IList<double?> Valor { set; get; }
    }
}
