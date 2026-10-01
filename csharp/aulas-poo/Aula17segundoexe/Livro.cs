using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17segundoexe
{
    public class Livro : Produto
    {
        public long Isbn;
        public string Autor;
    
    public Livro(int codigo, double preco, string autor, long Isbn) : base(codigo, preco)
    {
        Autor = autor;
        Isbn = Isbn;
    }
    public override void SetCodigo(int codigo)
        {
            codigo = codigo;
        }
        public override void setPreco(double preco)
        {
            Preco = preco;
        }
        public string getAutor()
        {
            return Autor;
        }
        public long getIsbn()
        {
            return Isbn;
        }
        public void setAutor(string Autor)
        {
            Autor = autor;
        }
        public void setIsbn(long Isbn)
        {
            Isbn = Isbn;
        }
        public void AtualizarPreco(double preco)
        {
            Preco = preco;
        }
    }

}