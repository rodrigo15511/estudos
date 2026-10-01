using System;

namespace Aula12
{
    public class MargeSort
    {
        // Método para ordenar o vetor
        static void Ordenar(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int meio = (inicio + fim) / 2;
                Ordenar(vetor, inicio, meio);          // Ordena a primeira metade
                Ordenar(vetor, meio + 1, fim);         // Ordena a segunda metade
                Intercalar(vetor, inicio, meio, fim);  // Intercala as duas metades
            }
        }

        // Método para intercalação
        static void Intercalar(int[] vetor, int inicio, int meio, int fim)
        {
            int[] aux = new int[vetor.Length];    // Vetor auxiliar
            for (int j = inicio; j <= fim; j++)
            {
                aux[j] = vetor[j];  // Copia os elementos para o vetor auxiliar
            }

            int i1 = inicio;   // Posição inicial da primeira metade
            int i2 = meio + 1; // Posição inicial da segunda metade
            int i3 = inicio;   // Posição para preenchimento do vetor original

            // Intercala os dois vetores
            while (i1 <= meio && i2 <= fim)
            {
                if (aux[i1] < aux[i2])
                {
                    vetor[i3] = aux[i1];
                    i1++;
                }
                else
                {
                    vetor[i3] = aux[i2];
                    i2++;
                }
                i3++;
            }

            // Se ainda houver elementos na primeira metade, copia-os
            while (i1 <= meio)
            {
                vetor[i3] = aux[i1];
                i1++;
                i3++;
            }

            // Se ainda houver elementos na segunda metade, copia-os
            while (i2 <= fim)
            {
                vetor[i3] = aux[i2];
                i2++;
                i3++;
            }
        }

        // Método para imprimir o vetor
        static void Imprimir(int[] vetor)
        {
            foreach (int num in vetor)
            {
                System.Console.Write(num + " ");
            }
            System.Console.WriteLine();
        }

        // Método principal
        static void Main(string[] args)
        {
            int[] vetor = { 3, 1, 5, 7, 3, 4 };

            System.Console.WriteLine("Vetor Desordenado:");
            Imprimir(vetor);   // Imprime o vetor desordenado

            Ordenar(vetor, 0, vetor.Length - 1); // Chama o método para ordenar

            System.Console.WriteLine("Vetor Ordenado:");
            Imprimir(vetor);   // Imprime o vetor ordenado
        }
    }
}
