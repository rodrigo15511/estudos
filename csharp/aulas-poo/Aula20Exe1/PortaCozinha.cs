using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula20Exe
{
    public class PortaCozinha : Porta
    {
        public PortaCozinha(string cor, float largura, float altura, double peso) : base(cor, largura, altura, peso)
        {
        }
        
        //Subscrevendo o metodo Abrir
        public override void Abrir()
        {
            System.Console.WriteLine("Porta da cozinha aberta");
        }
        public override void Fechar()
        {
            System.Console.WriteLine("A porta da cozinha esta fechada");
        }

    }
}