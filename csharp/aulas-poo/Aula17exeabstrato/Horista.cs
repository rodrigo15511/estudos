using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17exeabstrato
{
    public class Horista : Empregado
    {
        public double precoHora;
        public double horasTrabalhadas;

        public Horista(double precoHora, double horasTrabalhadas)
        {
            this.precoHora = precoHora;
            this.horasTrabalhadas = horasTrabalhadas;
        }
         public override double Vencimento()
         {
            return precoHora * horasTrabalhadas;
         }

    }
}