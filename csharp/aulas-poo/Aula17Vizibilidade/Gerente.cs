using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17Vizibilidade
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, double salario) : base(nome, salario, "Gerente")
        {

        }
        public void Imprimir()
        {
            ExibirInformacoes();
        }

        public void AtualizarCargoGerente(string novoCargo){
            AtualizarCargo(novoCargo)
        }
        public void CalcularImpostoGerente(){
            // System.Console.WriteLine(CalcularImposto());
        }
    }
}