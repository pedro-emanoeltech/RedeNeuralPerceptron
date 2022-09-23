using System.Collections.Generic;


namespace RedeNeuralPerceptronDomain.Entity
{
    public class Peso : Base
    {
        public int? QuantidadePeso { set; get; }
        public IList<double?> Valor { set; get; }
    }
}
