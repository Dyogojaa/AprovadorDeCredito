using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovadorDeCredito.Class
{
    public class PessoaFisica
    {
        /// <summary>
        /// Calcula o Valor da Parcela utilizando a Taxa de 3%
        /// </summary>
        /// <param name="finaciamento"></param>
        /// <returns></returns>
        public double Calcula(Financiamento finaciamento)
        {
            return Math.Round((finaciamento.ValorCredito *
                   Math.Pow((1 + 0.03), finaciamento.QtdParcelas) * 0.03) /
                   (Math.Pow((1 + 0.03), finaciamento.QtdParcelas) - 1), 2);

        }
    }
}
