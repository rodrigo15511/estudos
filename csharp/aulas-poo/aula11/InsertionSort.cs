using System;

namespace Aula_11
{
    class SelectionSort
    {
        static void Ordenar(int[] vetor)
        {
            int aux;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                int menorIndice = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[menorIndice])
                    {
                        menorIndice = j;
                    }
                }

                if (menorIndice != i)
                {
                    // Troca os elementos
                    aux = vetor[i];
                    vetor[i] = vetor[menorIndice];
                    vetor[menorIndice] = aux;
                }
            }
        }

        static void Imprimir(int[] vetor)
        {
            foreach (int num in vetor)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] vetor = { 64, 25, 12, 22, 11 };
            
            Console.WriteLine("Vetor desordenado:");
            Imprimir(vetor);

            Ordenar(vetor);

            Console.WriteLine("Vetor ordenado:");
            Imprimir(vetor);
        }
    }
}
