using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17segundoexe
{
    public abstract class Produto
    {
        public int Codigo;
        public double Preco;

        public Produto(int codigo, double preco)
        {
            Codigo = codigo;
            Preco = preco;
        }

        public abstract void SetCodigo();
        public abstract void setPreco();
        public abstract int getCodigo();
        public abstract double getPreco();   
        public virtual void AtualizarPreco()
        public override double Produto();
    }
}