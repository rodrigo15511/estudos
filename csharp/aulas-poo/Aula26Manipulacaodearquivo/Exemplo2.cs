// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula26Manipulacaodearquivo
// {
//     public class Exemplo2
//     {
//         static void Exe()
//         {
//             string inicioParh = @"C:\Users\rodrigoterra\Desktop\teste1.txt";
//             FileStream fs = null;
//             StreamReader sr = null;

//             try
//             {
//                 fs = new FileStream(inicioParh, FileMode.Open);
//                 sr = new StreamReader(fs);
//                 System.Console.WriteLine(line);
//             }
//             catch (IOException e)
//             { 
//                 System.Console.WriteLine("Erro");
//                 System.Console.WriteLine(e.Message);
//             }            
//             finally
//             {
//                 if (sr != null) sr.Close();
//                 if (fs != null)sr.Close();
//             }            
//         }
//     }
// }