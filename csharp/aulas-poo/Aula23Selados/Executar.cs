using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula23Selados
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            f.Salario(2000);
            f.Trabalhar();

            Cordenador c = new Cordenador();
            c.Salario(2000);
            c.Trabalhar();

            Gerente g = new Gerente();
            g.Salario(2000);
            g.Trabalhar();
        }
    }    
}