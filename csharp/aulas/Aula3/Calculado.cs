// using System;

// namespace Aula3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Digite o valor inicial:");
//             double valor = double.Parse(Console.ReadLine());

//             System.Console.WriteLine("Escolha um tipo de investimento:");
//             System.Console.WriteLine("1 - Poupança (3% ao ano)");
//             System.Console.WriteLine("2 - Renda Fixa (5% ao ano)");
//             System.Console.WriteLine("3 - Ações (10% ao ano com chance de perda de 5%)");
//             int resultado = int.Parse(Console.ReadLine());

//             System.Console.WriteLine("Quantos anos você pretende investir?");
//             int anos = int.Parse(Console.ReadLine());

//             double saldoFinal = valor;

//             for (int i = 0; i < anos; i++)
//             {
//                 if (resultado == 1)
//                 {
//                     saldoFinal += saldoFinal * 0.03; // 3% ao ano
//                 }
//                 else if (resultado == 2)
//                 {
//                     saldoFinal += saldoFinal * 0.05; // 5% ao ano
//                 }
//                 else if (resultado == 3)
//                 {
//                     double chancePerda = new Random().NextDouble();
//                     if (chancePerda < 0.5) // 50% de chance de perder 5%
//                     {
//                         saldoFinal -= saldoFinal * 0.05; // 5% de perda
//                     }
//                     else
//                     {
//                         saldoFinal += saldoFinal * 0.10; // 10% de rendimento
//                     }
//                 }
//                 else
//                 {
//                     System.Console.WriteLine("Opção inválida.");
//                     return; // Sai do programa se a opção for inválida
//                 }
//             }

//             System.Console.WriteLine($"Saldo estimado após {anos} anos: R$ {saldoFinal:F2}");
//         }
//     }
// }
