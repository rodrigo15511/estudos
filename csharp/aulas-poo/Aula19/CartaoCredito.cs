using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula19
{
    public class CartaoCredito : IPagamento, IAnuidade
    {
        public string NumeroCartao {get; set; }
        public DataTime DataVencimento {get; set; }
        public double ValorAnuidade{get; set; }

        // Construtor
        public CartaoCredito(string NumeroCartao)
        {
            NumeroCartao = NumeroCartao;
        }
        public CartaoCredito(string numeroCartao, Datatime dataVencimento, double valorAnuidade)
        {
            NumeroCartao = numeroCartao;
            DataVencimento = DataVencimento;
            ValorAnuidade = ValorAnuidade;
        }
        public void RealizarPagamento(double valor)
        {
            System.Console.WriteLine($"Comprovante de pagamento com o cartão {NumeroCartao} no valor de R$ {valor} realizado com sucesso com o cartao {NumeroCartao}");
        }
        public DataTime CalcularDataVencimento()
        {
            return Datatime.Now.AddYears(1);
        }
        public double CalcularValorAnuidade()
        {
            return 100;
        }
    }
}