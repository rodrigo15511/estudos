using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula19EXE
{
    public class Peixe : Animal, AnimalDeEstimacao
    {
        private string Nome "";
        public Peixe()
        {
            return Peixe;
        }
        public Peixe(string nomenclaturaome)
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
        System.Console.WriteLine("O peixe esta comendo");
    }
    public void come()
    {
        System.Console.WriteLine("O peixe esta comendo");
    }
    }
}