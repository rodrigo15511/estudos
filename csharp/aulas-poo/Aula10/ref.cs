// using System;
// namespace Aula10
// {
//     class Ref
//     {
//         static int Quadrado(int x){
//             return x * x;
//         }

//         static void QuadradoRef(ref int x){
//             x - x * x;
//         }
//         static int QuadradoOut(out int x)
//         {
//             x = 6;
//             return x * x;
//         }
//     static void Main(string[] args)
//     {
//         int a = 10;
//         System.Console.WriteLine(Quadrado(a));
//         System.Console.WriteLine(a);
//         QuadradoRef(ref a);
//         System.Console.WriteLine(a);    
//     }
//     }
// }