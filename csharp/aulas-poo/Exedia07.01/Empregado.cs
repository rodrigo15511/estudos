using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exedia07._01
{
    public class Empregado : Pessoa
    {
        public double Salario { get; set; }
        public static double SalarioMinimo { get; set; } = 240.0;
        public int LicencasPremioRecebidas { get; private set; }

          public Empregado(int licencasPremioRecebidas, double salario, string nome) : base(nome) 
        {
            this.Salario = salario;
            this.LicencasPremioRecebidas = LicencasPremioRecebidas;
        }
        public virtual double GetSalario()
        {
            return Salario;
        }
        public int GetLicencasPremioRecebidas()
        {
            return LicencasPremioRecebidas;
        }
        public void SetSalario(double salario)
        {
            Salario = salario;
        }
        public void SetLicencasPremioRecebidas(int LicencasPremioRecebidas)
        {
            LicencasPremioRecebidas = LicencasPremioRecebidas;
        }

    }
}