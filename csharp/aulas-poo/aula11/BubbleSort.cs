using System;

namespace Aula21123
{
    public class BubbleSort
    {
        static void Ordenar(int[] vetor)
        {
            int aux;
            for (int i = 0; i < vetor.Length - 1; i++)  
            {
                for (int j = 0; j < vetor.Length - 1 - i; j++)  
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
        }

        static void Imprimir(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] vetor = { 3, 6, 4, 7, 9 };  

            Console.WriteLine("Vetor desordenado:");
            Imprimir(vetor);

            Ordenar(vetor);

            Console.WriteLine("Vetor ordenado:");
            Imprimir(vetor);
        }
    }
}

