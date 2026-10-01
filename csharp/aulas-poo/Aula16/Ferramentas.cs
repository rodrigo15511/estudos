using System;

namespace Aula16
{
    public class Ferramentas
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

        public Ferramentas()
        {
            Nome = "Ferramentas";
            Preco = 0.0;
            Quantidade = 0;
        }

        public Ferramentas(string nome, double preco, int quantidade)
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
