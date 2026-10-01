using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exedia07._01
{
    public class Empregados
    {
        public int NumeroEmpregados { get; set; }
        public int NumeroMaximo { get; set; } = 50;
        public Empregado [] empregados = new Empregado[50];
        public Empregados(int numeroEmpregados, Empregado[] empregados)
        {
            NumeroEmpregados = numeroEmpregados;
            empregados = empregados;
        }
        public void insere(double salario, int licencas, string nome)
        {
            if (NumeroEmpregados < NumeroMaximo)
            {
                empregados[NumeroEmpregados] = new Empregado(salario, licencas, nome);
            }
            else
            {
                Console.WriteLine("Número máximo de empregados atingido.");
            }
        }

        public void imprime()
        {
            for (int i = 0; i < NumeroEmpregados - 1; i++)
            {
                Console.WriteLine("\nNome: " + empregado[i].GetName());
                Console.WriteLine("Salário: " + empregado[i].GetSalario());
                Console.WriteLine("Licenças prêmio recebidas: " + empregado[i].GetLicencasPremioRecebidas());
            }
        }

        public void write(String write)
        {
            Console.WriteLine(write);
        }

        public void read(String read)
        {
            Console.WriteLine(read);
        }

        public void doFolhaPagamento()
        {
            for (int i = 0; i < NumeroEmpregados; i++)
            {
                Console.WriteLine("Nome: " + empregado[i].GetName());
                Console.WriteLine("Salário: " + empregado[i].GetSalario());
                Console.WriteLine("Licenças prêmio recebidas: " + empregado[i].GetLicencasPremioRecebidas());
            }
        }

    }
}