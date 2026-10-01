using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exedia07._01
{
    public class Vendedor : Empregado
    {
        public double Comissao { get; set; }

        public Vendedor(double salario, int licencasPremioRecebidas, string nome, double comissao) :  base(salario, licencasPremioRecebidas, nome)
        {
            Comissao = comissao;
        }
        public double GetSalario()
        {
            return Salario + Comissao;
        }
    }
}