using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exedia07._01
{
    public class GerenteProducao : Empregado, Gerente
    {
        public GerenteProducao(double salario, int licencasPremioRecebidas, string nome) : base(salario, licencasPremioRecebidas, nome)
        {
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