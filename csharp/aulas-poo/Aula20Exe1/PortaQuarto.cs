using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula20Exe
{
    public class PortaQuarto : Porta
    {
        public PortaQuarto Quarto(string cor, float largura, float altura, double peso) : base(cor, largura, altura, peso)
        {
        }
        public override void Abrir()
        {
            System.Console.WriteLine("Porta aberta");
        }
        public override void Fechar()
        {
            System.Console.WriteLine("A porta esta fechada");
        }
    }
}