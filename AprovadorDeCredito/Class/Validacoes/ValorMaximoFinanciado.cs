using AprovadorDeCredito.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovadorDeCredito.Class.Validacoes
{
    public class ValorMaximoFinanciado : IValida
    {
        public bool Valida(Financiamento financiamento)
        {
            return financiamento.ValorCredito > 1.000000;
        }
    }
}
