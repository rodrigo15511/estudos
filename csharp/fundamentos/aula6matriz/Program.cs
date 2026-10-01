using System;
namespace aula6matriz
{
    public class Program
    {
        static void Teste ()
        {
    

            //Formas de declarar uma matriz
            int[,] matriz1 = new int[2, 2]; // 2 linhas e 2 colunas
            int[,] matriz2 = new int[2, 2]
                {
                    {1, 2},
                    {3, 4}
                };
            // Acessando elementos da matriz
            System.Console.WriteLine(matriz2[0, 0]);
            System.Console.WriteLine(matriz2[0, 1]);
            // Percorrendo a matriz
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    System.Console.WriteLine(matriz2[i, j]);
                }
            }
            // somando os elementos da matriz
            int[,] matrizA = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
            int[,] matrizB = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };
            int[,] matrizC = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

        }
    }
}