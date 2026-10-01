using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDia19
{
    public class Funcionario : Usuario
    {
        public string Cargo { get; set; }
        public Funcionario(string cargo, string nome, string cpf) : base(nome, cpf)
        {
            Cargo = cargo;
        }
    }
}