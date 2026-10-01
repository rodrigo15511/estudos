using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula23Selados
{
    public class Funcionario : Cordenador
    {
        public override Salario(int salario)
        {
            System.Console.WriteLine("Salario base:" + salario * 1.1);
        }
    }
}