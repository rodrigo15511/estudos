using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula20
{
    public class Aluno
    {
        private Aluno estudante;
        private Professor professor;

        public Escola(string nomeEstudadante)
        {
            estudante = new Aluno(nomeEstudadante);
        }

        //Metodo para Agregaçao que recebe de forma externa o professor
        public void Contratar professor(Professor professor)
        {
            this.professor = professor;
        }
    }
}