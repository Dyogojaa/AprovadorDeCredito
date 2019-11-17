using AprovadorDeCredito.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovadorDeCredito.Class
{
    public static class ValidacoesFinanciamento
    {
        public static bool Validar(Financiamento financiamento)
        {
            bool valida = false;
            valida = new Validacoes.ValorMaximoFinanciado().Valida(financiamento);
            if (valida)
                valida = new Validacoes.QuantidadeParcelas().Valida(financiamento);
            if (valida)
                valida = new Validacoes.ValidaPessoaJurica().Valida(financiamento);
            if (valida)
                valida = new Validacoes.ValidaDataPrimeiraParcela().Valida(financiamento);

            return valida;
        }

    }
}
