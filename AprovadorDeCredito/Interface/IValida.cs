using AprovadorDeCredito.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovadorDeCredito.Interface
{
    interface IValida
    {
        bool Valida(Financiamento financiamento);
    }
}
