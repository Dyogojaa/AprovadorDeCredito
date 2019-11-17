using AprovadorDeCredito.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovadorDeCredito.Class
{
    public class Imobiliario : ICredito
    {   
        /// <summary>
        /// Calcula o Valor da Parcela utilizando a Taxa de 9%
        /// </summary>
        /// <param name="finaciamento"></param>
        /// <returns></returns>
        public double Calcula(Financiamento finaciamento)
        {
            return Math.Round((finaciamento.ValorCredito *
                    Math.Pow((1 + 0.09), finaciamento.QtdParcelas) * 0.09) /
                    (Math.Pow((1 + 0.09), finaciamento.QtdParcelas) - 1), 2);

        }
    }
}
