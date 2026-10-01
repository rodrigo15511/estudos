using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula20
{
    public class Escola
    {
        public string Nome {get; set; }
        public Aluno(string nome)
        {
            Nome = nome;
        }
        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nome do aluno: {Nome}");
            System.Console.WriteLine($"Nome do Professor: {Professor}");
            professor.Ensinar()
        }
    }
}