using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17Vizibilidade
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario("Joao", 2000, "Analista");
            System.Console.WriteLine("Funcionario:" + funcionario.Nome);
            funcionario.Nome = "Pedri";
            System.Console.WriteLine("Funcionario:" + funcionario.Nome);
            funcionario.Cargo = "Gerente";
            
            Gerente gerente = new Gerente("Maria", 5000);
            System.Console.WriteLine("Gerente" + gerente.Nome);
            gerente.Nome = "Ciclano";
            System.Console.WriteLine("Gerente:" + gerente.Nome);
            gerente.AtualizarCargoGerente("Diretor");
            gerente.CalcularImpostoGerente();
        }
    }
}