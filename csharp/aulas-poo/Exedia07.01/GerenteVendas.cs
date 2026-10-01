using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exedia07._01
{
    public class GerenteVendas : Vendedor, Gerente
    {
        public Regiao Regiao { get; set; }
        public GerenteVendas(double salario, int licencasPremioRecebidas, string nome, double comissao, Regiao regiao) : base(salario, licencasPremioRecebidas, nome, comissao) 
        {
            Regiao = regiao;
        }
        public void autorizar() 
        {
            System.Console.WriteLine("Autorizado");
        }
        public bool concedeAumento() 
        {
            if (Salario > SalarioMinimo) 
            {
                Salario = 100;
                return true;
            }
            return false;
        }
        public double GetSalario() 
        {
            return Salario;
        }

        public bool autorizarLicencas() 
        {
            System.Console.WriteLine("Autorizado");
            return true;
        }
    }
}