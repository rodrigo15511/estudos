using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula19EXE
{
    public class Cachorro : Animal, AnimalDeEstimacao
    {
        private string Nome = " "
    }
    public Cachorro()
    {
    }

    public Cachorro(string Nome) : base(5)
    {
        this.Nome = nome;
    }
    public string GetNome()
    {
        return Nome;
    }
    public void setNome(string Nome)
    {
        this.GetNome = Nome;
    }
    public void brinca()
    {
        System.Console.WriteLine("O cachorro brinca");
    }
    public override void come()
    {
    }
}