using System;

namespace Aula99
{
    class Program1
    {
        public static void ExibirMatriz(int[,] matriz)
        {
            int n = matriz.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void RotacionarMatriz(int[,] matriz)
        {
            int n = matriz.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int temp = matriz[i, j];
                    matriz[i, j] = matriz[j, i];
                    matriz[j, i] = temp;
                }
            }

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int temp = matriz[i, j];
                    matriz[i, j] = matriz[n - i - 1, j];
                    matriz[n - i - 1, j] = temp;
                }
            }
        }

        static void Main(string[] args)
        {
            int[,] matriz = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Matriz Original:");
            ExibirMatriz(matriz);

            RotacionarMatriz(matriz);

            Console.WriteLine("\nMatriz Rotacionada (90 graus sentido horário):");
            ExibirMatriz(matriz);
        }
    }
}
    
          