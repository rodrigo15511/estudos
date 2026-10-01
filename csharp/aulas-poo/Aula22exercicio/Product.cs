using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula22exercicio
{
    public class Product
    {
        public string Nome { get; set; }
        public double preco { get; set; }

        public Product(string nome, double preco)
        {
            Nome = nome;
            preco = preco;
        }
    }
}