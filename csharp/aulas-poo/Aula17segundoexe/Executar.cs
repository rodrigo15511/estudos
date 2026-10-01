using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17segundoexe
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Produto[] produtos = new Produto[3];
            produtos[0] = new Livro(1, 20.0,"Autor1", 1234)
            produtos[1] = new CompactDisc(2, 30.0, "Artista 1", "Gravadora 1");
            produtos[2] = new Livro(3,40.0, "Autor 2", 234534)

            foreach(Produto produto in produtos){
                System.Console.WriteLine("Codigo" + produto.getCodigo());
                System.Console.WriteLine("Preco" + produto.getPreco());
                produtos.AtualizarPreco(produto.getPreco() * 1.1);
                System.Console.WriteLine("Preco atualizado: "+ produto.getPreco());
                System.Console.WriteLine();
            }
        }
    }
}