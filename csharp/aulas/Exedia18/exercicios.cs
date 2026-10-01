// using System;
// using System.Collections.Generic;

// namespace Exedia18
// {
//     public class BubbleSortt
//     {
        // static void Ordenar(List<int> lista)
        // {
        //     int aux;
        //     for (int i = 0; i < lista.Count - 1; i++)
        //     {
        //         for (int j = 0; j < lista.Count - 1 - i; j++)
        //         {
        //             if (lista[j] > lista[j + 1])
        //             {
        //                 aux = lista[j];
        //                 lista[j] = lista[j + 1];
        //                 lista[j + 1] = aux;
        //             }
        //         }
        //     }
        // }

        // static void Imprimir(List<int> lista)
        // {
        //     for (int i = 0; i < lista.Count; i++)
        //     {
        //         Console.Write(lista[i] + " ");
        //     }
        //     Console.WriteLine();
        // }

        // static void Main(string[] args)
        // {
        //     Console.WriteLine("Digite o número de elementos da lista:");
        //     int quantidade = int.Parse(Console.ReadLine());

        //     List<int> lista = new List<int>();

        //     Console.WriteLine("Digite os números:");
        //     for (int i = 0; i < quantidade; i++)
        //     {
        //         Console.Write($"Número {i + 1}: ");
        //         int numero = int.Parse(Console.ReadLine());
        //         lista.Add(numero);
        //     }

        //     Console.WriteLine("Lista original:");
        //     Imprimir(lista);

        //     Ordenar(lista);

        //     Console.WriteLine("Lista ordenada em ordem crescente:");
        //     Imprimir(lista);
        // }
        // Exe 2
// using System;
// using System.Collections.Generic;

// namespace Exedia18
// {
//     public class BubbleSortt
    // Exe 3

        // static void Ordenar(List<string> lista)
//         {
//             int n = lista.Count;

//             for (int i = 0; i < n - 1; i++)
//             {
//                 int indiceMinimo = i;

//                 for (int j = i + 1; j < n; j++)
//                 {
//                     if (string.Compare(lista[j], lista[indiceMinimo]) < 0)
//                     {
//                         indiceMinimo = j;
//                     }
//                 }

//                 if (indiceMinimo != i)
//                 {
//                     string temp = lista[i];
//                     lista[i] = lista[indiceMinimo];
//                     lista[indiceMinimo] = temp;
//                 }
//             }
//         }

//         static void Imprimir(List<string> lista)
//         {
//             foreach (var nome in lista)
//             {
//                 Console.WriteLine(nome);
//             }
//         }

//         static void Main(string[] args)
//         {
//             List<string> lista = new List<string>();

//             Console.WriteLine("Digite o número de nomes:");
//             int quantidade = int.Parse(Console.ReadLine());

//             Console.WriteLine("Digite os nomes:");
//             for (int i = 0; i < quantidade; i++)
//             {
//                 Console.Write($"Nome {i + 1}: ");
//                 lista.Add(Console.ReadLine());
//             }

//             Console.WriteLine("\nLista original:");
//             Imprimir(lista);

//             Ordenar(lista);

//             Console.WriteLine("\nLista ordenada em ordem alfabética:");
//             Imprimir(lista);
//         }
//     }
// }
    //exe4
    using System;
using System.Collections.Generic;

namespace Exercicio4
{
    class Program
    {
        static void Ordenar(List<int> lista)
        {
            int n = lista.Count;

            for (int i = 1; i < n; i++)
            {
                int chave = lista[i];
                int j = i - 1;

                while (j >= 0 && lista[j] < chave)
                {
                    lista[j + 1] = lista[j];
                    j--;
                }

                lista[j + 1] = chave;
            }
        }

        static void Imprimir(List<int> lista)
        {
            foreach (var numero in lista)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            Console.WriteLine("Digite o número de elementos:");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os números:");
            for (int i = 0; i < quantidade; i++)
            {
                lista.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\nArray original:");
            Imprimir(lista);

            Ordenar(lista);

            Console.WriteLine("\nArray ordenado em ordem decrescente:");
            Imprimir(lista);
        }
    }
}



    
