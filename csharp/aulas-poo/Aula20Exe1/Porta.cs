using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula20Exe
{
    public class Porta
    {
        //Propriedades
        public string Cor { get; set; }
        public float Largura { get; set; }
        public float Altura { get; set; }
        public double Peso { get; set; }


        public Porta(string cor, float largura, float altura, double peso)
        {
            Cor = cor;
            Largura = largura;
            Altura = altura;
            Peso = peso;
        }

        //Metodos que serao herdados
        public virtual void Abrir()
        {
            System.Console.WriteLine("Porta aberta");
        }
        public virtual void Fechar()
        {
            System.Console.WriteLine("A porta esta fechada");
        }
    }
}