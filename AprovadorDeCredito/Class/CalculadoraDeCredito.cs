using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovadorDeCredito.Class
{
    public class CalculadoraDeCredito
    {
        public double Calcula(Financiamento finaciamento)
        {
            return new Direto().Calcula(finaciamento);
        }
    }
}
