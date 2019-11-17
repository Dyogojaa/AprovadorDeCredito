using AprovadorDeCredito.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovadorDeCredito
{
    class Program
    {
        static void Main(string[] args)
        {

            int CodCliente = 0;
            string Nome = string.Empty;
            double ValorCredito = 0;
            Status st = Status.EmAnalise;
            Tipo tp = Tipo.Direto;
            int Parcelamento = 0;
            DateTime Data = DateTime.Now;
            string tipo = "1";

            Console.WriteLine("Digite o Codigo do Cliente:");
            CodCliente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Codigo do Nome do Cliente:");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite o Codigo do Valor Financiado:");
            ValorCredito = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a Quantidade de Parcelas:");
            Parcelamento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Data de Vencimento:");
            Data = Convert.ToDateTime(Console.ReadLine());


            Console.WriteLine("Digite o Tipo de Credito ");
            Console.WriteLine("1 - Direto");
            Console.WriteLine("2 - Consignado ");
            Console.WriteLine("3 - Pessoa Juridica ");
            Console.WriteLine("4 - Pessoa Fisica ");
            Console.WriteLine("5 - Imobiliario ");
            Console.WriteLine("Digite o Tipo de Credito ");

            tipo = Console.ReadLine();


            if ("1".Equals(tipo))
                tp = Tipo.Direto;
            if ("2".Equals(tipo))
                tp = Tipo.Consignado;
            if ("3".Equals(tipo))
                tp = Tipo.Pessoajuridica;
            if ("4".Equals(tipo))
                tp = Tipo.Pessoafisica;
            if ("5".Equals(tipo))
                tp = Tipo.Imobiliario;

                        
            Financiamento financiamento = new Financiamento(CodCliente, Nome, ValorCredito, st, tp, Parcelamento, Data);


            CalculadoraDeCredito calc = new CalculadoraDeCredito();

            var ValorParcelas = calc.Calcula(financiamento);
            var ValorTotalFinanciamento = Math.Round((ValorParcelas * financiamento.QtdParcelas), 2);

            bool ValidaFinanciamento = ValidacoesFinanciamento.Validar(financiamento);

            var status = financiamento.Status;

            if (ValidaFinanciamento)
                status = Status.Aprovado;
            else
                status = Status.Rejeitado;



            Console.WriteLine($"Valor Financiado: {financiamento.ValorCredito}");
            Console.WriteLine($"Valor da Parcela: {ValorParcelas}");
            Console.WriteLine($"Valor Total Financiamento: {ValorTotalFinanciamento}");
            Console.WriteLine($"Status: {status}");

            Console.ReadLine();



        }

        private static Tipo SelecionaTipo(Tipo tp)
        {
           
            return tp;
        }
    }
}
