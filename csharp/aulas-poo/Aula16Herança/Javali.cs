using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula16Herança
{
    public class Javali : Animal
    {
        public bool Selvagem;

        public Javali(bool Selvagem)
        {
            this.Selvagem = Selvagem;
        }
        public override int getVelocidadeMaxima()
         {
           return 35;
         }
         public override bool setSelvagem(bool s)
         {
            return "Sim";
         }
    }
}