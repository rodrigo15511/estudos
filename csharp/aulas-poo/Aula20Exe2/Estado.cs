using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula20Exe2
{
    public class Estado
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public Estado(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        public string GetNome()
        {
            return Nome;
        }
        public string GetSigla()
        {
            return Sigla;
        }
    }
}