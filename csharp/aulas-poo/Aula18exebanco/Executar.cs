using System;
using System.Globalization;

namespace Aula18exebanco
{
    public class Executar
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.WriteLine("Entre o número da sua conta:");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o nome do titular:");
            string titular = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine().ToLower());

            if (resp == 's')
            {
                Console.WriteLine("Entre o valor do depósito inicial:");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroConta, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com o valor do depósito:");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com o valor do saque:");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(saque);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados da conta:");
            Console.WriteLine(conta);
        }
    }

    // Classe ContaBancaria
    public class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        private double Saldo;

        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial = 0)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = depositoInicial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public void Sacar(double valor)
        {
            const double taxa = 5.00;
            if ((valor + taxa) <= Saldo)
            {
                Saldo -= (valor + taxa);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {NomeTitular}, Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
