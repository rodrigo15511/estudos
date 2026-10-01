using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula20Exe2
{
    public class Vendedor : Funcionario
    {
        public EquipeVenda Equipe { get; set; }
         public Vendedor(string nome, DateTime nascimento, string cpf, Endereco endereco, EquipeVenda equipe)
        : base(nome, nascimento, cpf, endereco)
    {
        Equipe = equipe;
    }
    public float GetSalario()
    {
        return 1000;
    }
    }
}