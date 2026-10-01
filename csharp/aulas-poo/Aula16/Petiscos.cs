using System;
namespace Aula16
{

    public class Petiscos
    {
            public string? Nome;
            public double Preco;
            public int Quantidade;

        public Petiscos()
        {
            this.Nome = "Petiscos";
            this.Preco = 0.0;
            this.Quantidade = 0;
        }

        public Petiscos(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }
        public double CalcularEstoque()
        {
            return Preco * Quantidade;
        }
    }
}