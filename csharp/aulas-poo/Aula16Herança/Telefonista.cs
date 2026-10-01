using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula16Herança
{
    public class Telefonista : Funcionario
    {
        public string EstacaoDeTrabalho;

         public Telefonista(string nome, string cpf, double salario, string setor) :base(nome, cpf, salario)
         {
            this.EstacaoDeTrabalho = EstacaoDeTrabalho;
         }
         public override double GetBonificacao()
    {
        return Salario * 0.05;
    }
    public override void ImprimirDados()
    {
        System.Console.WriteLine("Nome" + Nome);
        System.Console.WriteLine("CPF" + CPF);
        System.Console.WriteLine("EstacaodeTrabalho" + EstaçaodeTrbalho);
        System.Console.WriteLine("Bonificaçao " + GetBonificacao());
    }
    static void AtenderTelefone()
    {
        System.Console.WriteLine("Atender telefone");
    }

    }
}