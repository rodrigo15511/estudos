// using System;

// namespace Aula10
// {
//     class Recursao
//     {
//         // Função recursiva para obter os números pares
//         static int[] ObterPares(int[] vetor, int indice = 0)
//         {
//             // Caso base: quando o índice excede o tamanho do vetor
//             if (indice >= vetor.Length)
//             {
//                 return new int[0];
//             }

//             // Chama recursivamente os pares restantes do vetor
//             int[] paresRestantes = ObterPares(vetor, indice + 1);

//             // Verifica se o valor do índice é par
//             if (vetor[indice] % 2 == 0)
//             {
//                 // Se for par, cria um novo array com espaço para o par e os pares restantes
//                 int[] resultado = new int[paresRestantes.Length + 1];
//                 resultado[0] = vetor[indice]; // Adiciona o número par no início
//                 paresRestantes.CopyTo(resultado, 1); // Copia os pares restantes para o novo array
//                 return resultado;
//             }
//             else
//             {
//                 // Se não for par, apenas retorna os pares restantes
//                 return paresRestantes;
//             }
//         }

//         static void Main(string[] args)
//         {
//             int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8 };
//             int[] pares = ObterPares(vetor);

//             // Exibe os números pares encontrados
//             foreach (var item in pares)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }
