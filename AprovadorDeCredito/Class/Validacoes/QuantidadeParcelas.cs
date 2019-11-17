using AprovadorDeCredito.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovadorDeCredito.Class.Validacoes
{
    public class QuantidadeParcelas : IValida
    {
        public bool Valida(Financiamento financiamento)
        {
            return financiamento.QtdParcelas < 72 || financiamento.QtdParcelas > 5;
        }
    }
}
