// using System;
// namespace Aulaaaaaa
// {
//     class Funcaorecursiva{
//         // Os pare de um vetor com recursao
//         static int Pares (int [] vetor, int n)
//         {
//             if (n == 0)
//                 return 0;
//             else if (vetor[n - 1] % 2 == 0)
//                 return vetor[n - 1] + Pares(vetor, n -1);
//             else
//                 return Pares(vetor, n - 1);
//         }

//         static int Fatorial(int n)
//         {
//             if (n == 0)
//                 return 1;
//             else
//                 return n * Fatorial(n -1);
//         }
//         static int Fibonacci(int n)
//         {
//             if (n == 0 || n == 1)
//                 return 1;
//             else
//                 return Fibonacci(n -1) + Fibonacci(n - 2);
            
//         }

//         static int Fatorial12(int n)
//         {
//             int fatorial = 1;
//             for(int i - 0; i <= n; i++)
//             {
//             fatorial *= int;
//             return fatorial;
//             }
//         }
//         static int Fibonacci(int n)
//         {
//             int a=0, b = 1, c =1;
//             for(int i =2; i <= n;i++)
//             {
//                 c = a + b;
//                 a = b;
//                 b = c;
//             }
//             return c; 
//         }
        
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Digite um numero");
//             int num = int.Parse(Console.ReadLine());
//             System.Console.WriteLine(Fibonacci(num));
//             // Chamar a funçao Par
//             int[] vetor = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
//             System.Console.WriteLine("A os pares é: + Pares(vetor, vetor.Length)");
//         }        
//     }

// }
