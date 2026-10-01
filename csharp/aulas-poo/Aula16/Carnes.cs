using System;

namespace Aula16
{
    public class Carnes
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

        public Carnes()
        {
            Nome = null;
            Preco = 0.0;
            Quantidade = 10;
        }

        public Carnes(string nome, double preco, int quantidade)
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
