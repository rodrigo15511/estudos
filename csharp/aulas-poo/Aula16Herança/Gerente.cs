using System;

namespace Aula16Herança
{

    public class Gerente : Funcionario
    {

        public string Setor;

        public Gerente(string nome, string cpf, double salario, string setor) :base(nome, cpf, salario)
        this.Setor = setor;
        
    }
    public override double GetBonificacao()
    {
        return Salario * 0.15;
    }

    public override void ImprimirDados()
    {
        System.Console.WriteLine("Nome" + Nome);
        System.Console.WriteLine("CPF" + CPF);
        System.Console.WriteLine("Salario" + Salario);
        System.Console.WriteLine("Bonificaçao " + GetBonificacao());
    }
     public void GerenciarEquipe()
        {
            Console.WriteLine("Gerenciando equipe");
        }

}