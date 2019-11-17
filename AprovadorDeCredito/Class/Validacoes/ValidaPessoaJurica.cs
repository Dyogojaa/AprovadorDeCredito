using AprovadorDeCredito.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovadorDeCredito.Class.Validacoes
{
    public class ValidaPessoaJurica : IValida
    {
        public bool Valida(Financiamento financiamento)
        {
            if (Tipo.Direto.Equals(financiamento.Tipo))
                return Tipo.Direto.Equals(financiamento.Tipo) && financiamento.ValorCredito >= 15000;
            else
                return true;
        }
    }
}
