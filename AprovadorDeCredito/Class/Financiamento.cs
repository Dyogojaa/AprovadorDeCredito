using System;

namespace AprovadorDeCredito.Class
{
    public class Financiamento
    {

        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public double ValorCredito { get; set; }
        public Status Status { get; set; }
        public Tipo Tipo { get; set; }
        public int QtdParcelas { get; set; }
        public DateTime DataPrimeiroVencimento { get; set; }
        
        public Financiamento(int idCliente, string nomeCliente, double valorCredito, Status status, Tipo tipo, int qtdParcelas, DateTime dataPrimeiroVencimento)
        {
            IdCliente = idCliente;
            NomeCliente = nomeCliente;
            ValorCredito = valorCredito;
            Status = status;
            Tipo = tipo;
            QtdParcelas = qtdParcelas;
            DataPrimeiroVencimento = dataPrimeiroVencimento;         
        }

    }

    public enum Status
    {
        EmAnalise = 0,
        Aprovado = 1,
        Pendente = 2,
        Rejeitado = 3

    }

    public enum Tipo
    {
        Direto = 1,
        Consignado = 2,
        Pessoajuridica = 3,
        Pessoafisica = 4,
        Imobiliario = 5
    }
}