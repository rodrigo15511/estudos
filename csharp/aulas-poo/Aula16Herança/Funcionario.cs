using System;

namespace Aula16Heranca 
{
    public class Funcionario
    {
        public string Nome;
            public string CPF;
            public double salario;

    }
    public virtual double GetBonificacao()
    {
        return salario * 0.10;
    }

    public virtual void ImprimirDados()
    {
        System.Console.WriteLine("Nome" + Nome);
        System.Console.WriteLine("CPF" + CPF);
        System.Console.WriteLine("Salario" + Salario);
        System.Console.WriteLine("Bonificaçao " + GetBonificacao());
    }


}