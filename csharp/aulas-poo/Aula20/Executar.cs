using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula20
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Escola escola = new Escola("Joao");
            Professor professor = new Professor("Maria");
            escola.ContratarProfessor(professor);
            escola.MostrarInfo();
        }
    }
}