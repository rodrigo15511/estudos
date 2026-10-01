// using System;

// namespace Aula4
// {
//     class Forcalculadora
//     {
//         static void Teste ()
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
//             double taxa = 1;

            
            
//                 if (resultado == 1)
//                 {
//                     for (int i = 0; i < anos; i++){
//                       taxa +=  0.03;  
//                     }
//                     System.Console.WriteLine(taxa * saldoFinal);
//                 }
//                 else if (resultado == 2)
//                 {
//                     for (int i = 0; i < anos; i++){
//                     taxa +=  1.05;  
//                     }   

//                     System.Console.WriteLine(taxa * saldoFinal); 
//                 }
//                 else if (resultado == 3)
//                 {
//                     for (int i = 0; i < anos; i++){
                    
//                     if (anos != 3){
//                     taxa +=  0.10;  
//                     }else {
//                         taxa -= 0.05;
//                     }
//                     System.Console.WriteLine(taxa * taxa);
                    
//                 }
//                 }
               
            

//             System.Console.WriteLine($"Saldo estimado após {anos} anos: R$ {saldoFinal:F2}");
//         }
//     }
// }
