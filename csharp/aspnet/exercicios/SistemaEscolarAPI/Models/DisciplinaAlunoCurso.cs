using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEscolarAPI.Models
{
    public class DisciplinaAlunoCurso
    {
        public int Id {get; set; }
        public string Descricao {get; set; }
        public ICollection<Disciplina> Disciplina{ get; set; } = new List<Disciplina>();
        public ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();
    }
}