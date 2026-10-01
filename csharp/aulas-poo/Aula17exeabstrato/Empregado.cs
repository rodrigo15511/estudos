using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17exeabstrato
{
    public class Empregado
    {
        public string Nome;
        public string Sobrenome;
        public string Cpf;

        public Empregado(string nome, string sobrenome, string cpf)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Cpf = cpf;
        }

        public override double Vencimento();
    }
}