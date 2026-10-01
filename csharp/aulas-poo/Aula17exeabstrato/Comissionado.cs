using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17exeabstrato
{
    public class Comissionado
    {
        public class Comissionado : Empregado
    {
        public double totalVenda;
        public double taxaComissao;
        
        public Comissionado(double totalVenda, double taxaComissao)
        {
            this.totalVenda = totalVenda;
            this.taxaComissao = taxaComissao;
        }
        public override double Vencimento()
        {
            return totalVenda * taxaComissao;
        }
    }
    }
}