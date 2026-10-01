using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula19EXE
{
    public class Formiga : Animal
    {
        public Formiga() : base(6)
        {
        }
        public void Come()
        {
            System.Console.WriteLine("A formiga come");
        }
    }
}