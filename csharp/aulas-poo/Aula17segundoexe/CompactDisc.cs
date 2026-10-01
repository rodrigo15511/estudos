using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17segundoexe
{
    public class CompactDisc : Produto
    {
        public string Artista;
        public string Gravadora;

        public CompactDisc(int codigo, double preco, string artista, string gravadora) : base(codigo, preco)
        {
            Artista = artista;
            Gravadora = gravadora;
        }
        public override void SetCodigo(int codigo)
        {
            codigo = codigo;
        }
        public override void setPreco(double preco)
        {
            Preco = preco;
        }
        public string getArtista()
        {
            return Artista;
        }
        public string getGravadora()
        {
            return Gravadora;
        }
        public void setArtista(string artista)
        {
            Artista = artista;
        }
        public void AtualizarPreco(double preco)
        {
            Preco = preco;
        }
    }
}