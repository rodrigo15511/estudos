// using System;

// namespace Aula5
// {
//     class Program
//     {
//         static void Teste ()
//         {

//             int Maior = int.Maxvalue;
//             int Menor = int.MinValue;
//             int numero = 0;
//             System.Console.WriteLine("Digite 10 numeros: ");
//             for (int i = 0; i < 10; i++)
//             {
//                 numero = int.Parse(Console.ReadLine());
//             }
//             if (numero > Maior)
//             {
//                 numero = Maior;
//             }
//             if (numero < Menor)
//             {
//                 numero = Menor;
//             }
//             else
//             {
//                 System.Console.WriteLine("Digite um numero positivo: ");
//             }
//             System.Console.WriteLine($"O maior numero eh : {Maior}");
//             System.Console.WriteLine($"O menor numero eh : {Menor}");

//         }
//     }
// }