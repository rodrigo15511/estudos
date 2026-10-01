// using System;
// namespace Aula7
// {
//     public class Aula6
//     {
//         static void Main(string[] args)
//         {
//             int [] numeros = new int[10];

//             for (int i = 0; i < 10; i++)
//             {
//                 System.Console.WriteLine("Digite os numero: ");
//                 numeros[i] = int.Parse(Console.ReadLine());    
//             }

            
//             int maior = numeros[0];
//             int menor = numeros[0];

//             for(int i = 1; i < 10 ; i++)
//             {
//                 if(numeros[i]> maior){
//                     maior = numeros[i];
//                 }
//                 if(numeros[i]< menor){
//                     menor = numeros[i];
//                 }
                
//             }
//             System.Console.WriteLine($"O maior eh {maior}");
//             System.Console.WriteLine($"O menor eh {menor}");
//         }
//     }
// }    