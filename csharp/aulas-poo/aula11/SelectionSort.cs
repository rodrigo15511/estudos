namespace Aula_11
{
    class SelectionSor
    {
        public class Selection
        {

            static void Ordenar(int[] vetor)
            {
                int menor, aux;
                for (int i = 0; i < vetor.Length - 1; i++)  // Correção aqui, o loop vai até vetor.Length - 1
                {
                    menor = i;
                    for (int j = i + 1; j < vetor.Length; j++)
                    {
                        if (vetor[j] < vetor[menor])  // Corrigido para ordem crescente
                        {
                            menor = j;
                        }
                    }
                    // Troca os elementos
                    aux = vetor[i];
                    vetor[i] = vetor[menor];
                    vetor[menor] = aux;
                }
            }

            static void Imprimir(int[] vetor)
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    System.Console.Write(vetor[i] + " ");  // Corrigido para imprimir no mesmo linha
                }
                System.Console.WriteLine();  // Adiciona uma nova linha no final
            }

            static void Main(string[] args)
            {
                int[] vetor = { 3, 1, 5, 7, 3, 4 };
                System.Console.WriteLine("Vetor Desordenado");
                Imprimir(vetor);
                Ordenar(vetor);
                System.Console.WriteLine("Vetor Ordenado");
                Imprimir(vetor);
            }
        }
    }
}
