using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEscolarAPI.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        //De acordo com o diagrama inicial isso nao eh recomendado porem eu

        //public ICollection<Aluno> Alunos { get; set; }
        //public ICollection<DisciplinaAluno> DisciplinaAlunos { get; set; }

        public ICollection<DisciplinaAlunoCurso> DisciplinaAlunoCursos { get; set; }

    }
}