using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula20Exe2
{
    public class Cidade
    {
        public string Nome { get; set; }
        public Estado Estado { get; set; }
        public Cidade(string nome, Estado estado)
        {
            Nome = nome;
            Estado = estado;
        }
        public string GetNome()
        {
            return Nome;
        }
        public Estado GetEstado()
        {
            return Estado;
        }
    }
}