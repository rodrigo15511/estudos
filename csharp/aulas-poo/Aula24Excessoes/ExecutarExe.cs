using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula24Excessoes.ExercicioFixaçao;

namespace Aula24Excessoes
{
    public class ExecutarExe
    {
        static void Main(string[] args)
        {
           try
            {
                Console.WriteLine("Entre com os dados da conta:");
                Console.Write("Número: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Titular: ");
                string holder = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Limite de saque: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.Write("\nEntre com o valor para saque: ");
                double amount = double.Parse(Console.ReadLine());

                account.Withdraw(amount);
                Console.WriteLine($"Novo saldo: {account.Balance:F2}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro de formatação! Verifique os valores inseridos.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}
