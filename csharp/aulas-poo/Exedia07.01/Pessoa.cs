using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exedia07._01
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public void SetNome(string nome)
        {
            this.Nome = nome;
        }
        public string GetNome()
        {
            return Nome;
        }
    }
}