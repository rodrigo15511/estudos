using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula20Exe2
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; } 
        public string Cpf { get; set; }
        public Endereco Endereco { get; set; }
        public Funcionario(string nome, DateTime nascimento, string cpf, Endereco enderecos)
        {
            Nome = nome;
            Nascimento = nascimento;
            Cpf = cpf;
            enderecos = enderecos;
        }
        public string GetNome()
        {
            return Nome;
        }
        public override Datetime GetNascimento()
        {
            return Nascimento;
        }
        public string GetCpf()
        {
            return Cpf;
        }
        public Endereco GetEndereco()
        {
            return Endereco;
        }
    }
}