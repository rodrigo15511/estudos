using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDia19
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPubli { get; set; }
        public int NumDisponivel { get; set; }
        public Livro (string titulo, string autor, int anoPubli, int numDisponivel)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPubli = anoPubli;
            NumDisponivel = numDisponivel;
        }

    }
}