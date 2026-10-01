using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula22exercicio
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string email { get; set; }
        public date BirthDate { get; set; }

        public Cliente(string nome, string email, delegate birthDate)
        {
            Nome = nome;
            Email = email;
            BirthDate = birthDate;
        }
    }
}