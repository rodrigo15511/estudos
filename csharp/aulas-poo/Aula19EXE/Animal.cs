using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula19EXE
{
    public abstract class Animal
    {
        protected int Pernas = 4;
    
    public Animal (int pernas);
    {
        Pernas = pernas;
    }

    public void Caminha();
    {
        System.Console.WriteLine("O animal caminha");
    }
    public virtual void Come();
    {
        System.Console.WriteLine("O animal come");
    }
    }
}