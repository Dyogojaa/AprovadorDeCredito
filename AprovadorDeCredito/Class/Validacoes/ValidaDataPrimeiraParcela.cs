using AprovadorDeCredito.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovadorDeCredito.Class.Validacoes
{
    public class ValidaDataPrimeiraParcela : IValida
    {
        public bool Valida(Financiamento financiamento)
        {
            return financiamento.DataPrimeiroVencimento >= DateTime.Now.AddDays(15)
                && financiamento.DataPrimeiroVencimento <= DateTime.Now.AddDays(40); 
        }
    }
}
