using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula20Exe2
{
    public class Gerente : Funcionario
    {
    public Gerente(string nome, DateTime nascimento, string cpf, Endereco endereco)
    : base(nome, nascimento, cpf, endereco)
    {
    }

    public void GetSalario()
    {
        Console.WriteLine("Método GetSalario chamado para Gerente.");
    }
    }
}    