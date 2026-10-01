using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17exeabstrato
{
    public class Assalariado : Empregado
    {
        public double Salario;
        
        public Assalariado(double salario)
        {
            this.salario = salario;
        }
        public override double Vencimento()
        {
            return Salario;
        }
    }
}