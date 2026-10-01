// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula26Manipulacaodearquivo
// {
//     public class Exemplo1
//     {
//         // static void Main(string[] args)
//         {
//             string inicioParh = @"C:\Users\rodrigoterra\Desktop\teste1.txt";
//             string finalFile = @"C:\Users\rodrigoterra\Desktop\teste2.txt";

//             try
//             {
//                 FileInfo fileInfo = new FileInfo(inicioParh);
//                 fileInfo.CopyTo(finalFile);
//                 string[] line = fileInfo.ReadAllLines(inicioParh);
//                 foreach (string item in line)
//                 {
//                     System.Console.WriteLine(item);
//                 }
//             }
//             catch (IOException e)
//             {
//                 System.Console.WriteLine("Erro");
//                 System.Console.WriteLine(e.Message);
//             }
//         }
//     }
// }