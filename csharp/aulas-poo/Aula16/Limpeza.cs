using System;

namespace Aula16
{
    public class Limpeza
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;


        public Limpeza()
        {
            Nome = "Produtos de limpeza";
            Preco = 0.0;
            Quantidade = 0;
        }

        public Limpeza(string nome, double preco, int quantidade)
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
