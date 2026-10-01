// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Desafio
// {
//     class Aluno
//         {
//             static void Main(string[] args){

//             // Matriz Alunos          
//             var matrizDados = new dynamic[30, 5]
//         {
//             { "Aluno1", 20, 202301, 10.5, 2 },
//             { "Aluno2", 22, 202302, 20.3, 1 },
//             { "Aluno3", 21, 202303, 30.1, 3 },
//             { "Aluno4", 23, 202304, 40.2, 0 },
//             { "Aluno5", 20, 202305, 50.5, 4 },
//             { "Aluno6", 22, 202306, 60.7, 2 },
//             { "Aluno7", 21, 202307, 70.8, 1 },
//             { "Aluno8", 23, 202308, 80.9, 0 },
//             { "Aluno9", 20, 202309, 90.0, 3 },
//             { "Aluno10", 22, 202310, 100.5, 2 },
//             { "Aluno11", 21, 202311, 110.3, 0 },
//             { "Aluno12", 23, 202312, 120.1, 1 },
//             { "Aluno13", 20, 202313, 130.2, 2 },
//             { "Aluno14", 22, 202314, 140.4, 0 },
//             { "Aluno15", 21, 202315, 150.6, 1 },
//             { "Aluno16", 23, 202316, 160.7, 3 },
//             { "Aluno17", 20, 202317, 170.9, 2 },
//             { "Aluno18", 22, 202318, 180.2, 0 },
//             { "Aluno19", 21, 202319, 190.3, 4 },
//             { "Aluno20", 23, 202320, 200.4, 2 },
//             { "Aluno21", 20, 202321, 210.5, 1 },
//             { "Aluno22", 22, 202322, 220.6, 3 },
//             { "Aluno23", 21, 202323, 230.7, 0 },
//             { "Aluno24", 23, 202324, 240.8, 2 },
//             { "Aluno25", 20, 202325, 250.9, 1 },
//             { "Aluno26", 22, 202326, 260.1, 0 },
//             { "Aluno27", 21, 202327, 270.2, 3 },
//             { "Aluno28", 23, 202328, 280.3, 4 },
//             { "Aluno29", 20, 202329, 290.4, 2 },
//             { "Aluno30", 22, 202330, 300.5, 1 }
//         };
//         Media(matrizDados);
//         Melhores(matrizDados);

//      //    ImprimirMatriz(matrizDados);
//      //    System.Console.WriteLine("\nAluno com mais faltas:");
//      //        Aluno alunoComMaisFaltas = alunoComMaisFaltas(falta);
//      //        System.Console.WriteLine($"Nome: {alunoComMaisFaltas.Nome}, Idade: {alunoComMaisFaltas.Idade}, Matricula: {alunoComMaisFaltas.Matricula}, Nota final: {alunoComMaisFaltas.NotaFinal}, Faltas: {alunoComMaisFaltas.QuantidadeFaltas}")
//     }




// static void InsertionSort(object[,] alunos)
//         {
//             int n = alunos.GetLength(0); // número de alunos

//             // Insertion Sort
//             for (int i = 1; i < n; i++)
//             {
//                 // A chave é o elemento atual
//                 object[] chave = new object[alunos.GetLength(1)];
//                 for (int j = 0; j < alunos.GetLength(1); j++)
//                     chave[j] = alunos[i, j];

//                 // Move os elementos da parte ordenada para a direita
//                 int jPos = i - 1;
//                 while (jPos >= 0 && (double)alunos[jPos, 3] > (double)chave[3])
//                 {
//                     for (int k = 0; k < alunos.GetLength(1); k++)
//                         alunos[jPos + 1, k] = alunos[jPos, k];

//                     jPos--;
//                 }

//                 // Coloca a chave na posição correta
//                 for (int k = 0; k < alunos.GetLength(1); k++)
//                     alunos[jPos + 1, k] = chave[k];
//             }
//         }

//         static void ImprimirMatriz(object[,] matriz)
//         {
//             for (int i = 0; i < matriz.GetLength(0); i++)
//             {
//                 for(int j = 0; j < 1; j++)
//                 {
//                     Console.Write($"Nome: {matriz[i,0]}; Idade: {matriz[i,1]}; Matricula: {matriz[i,2]}; Nota Final: {matriz[i,3]}; Faltas: {matriz[i,4]};");
//                 }
//                 System.Console.WriteLine("\n");
//             }
//         }

        

// //  static Aluno AlunoComMaisFaltas(object[,] matriz)
// //         {
// //             double MaiorFalta = matriz[0,4];
// //             int linha = 0;
// //             int soma = 0;


// //             for (int i = 1; i < matriz.GetLength(0); i++)
// //             {
// //                 if ()
// //             }

            

// //             return alunoComMaisFaltas;
// //         }

//         static void Media(object[,] mat)
//           {
//                double somaIdade = 0;
//                double somaNota = 0;

//                double mediaIdade;
//                double mediaNota;

//                for (int i = 0; i < mat.GetLength(0); i ++)
//                {
//                     somaIdade += Convert.ToDouble(mat[i,1]);
//                     somaNota += Convert.ToDouble(mat[i,3]);
//                }
//                mediaIdade = somaIdade/mat.GetLength(0);
//                mediaNota = somaNota/mat.GetLength(0);
               
               
//                System.Console.WriteLine($"{somaIdade:F2}");
//                System.Console.WriteLine($"{somaNota:F2}");
//                System.Console.WriteLine($"{mediaIdade:F2}");
//                System.Console.WriteLine($"{mediaNota:F2}");



//           }
//           static void MostrarTop5Alunos(object[,] alunos)
//         {
//             Console.WriteLine("Top 5 Melhores Alunos (por Nota Final):");

//             for (int i = 0; i < 5; i++)
//             {
//                 Console.WriteLine($"Nome: {alunos[i, 0]}, Idade: {alunos[i, 1]}, Matrícula: {alunos[i, 2]}, Nota Final: {alunos[i, 3]}, Faltas: {alunos[i, 4]}");
//             }
//         }
//         static void Melhores(object[,] alunos)
//         {
//           System.Console.WriteLine("TOP 5 MELHORES de 2024: ");
//           for(int i = 0; i < 5; i++)
//           {
//                Console.WriteLine($"{i+1} - Nome: {alunos[i, 0]}, Idade: {alunos[i, 1]}, Matrícula: {alunos[i, 2]}, Nota Final: {alunos[i, 3]}, Faltas: {alunos[i, 4]}");

//           }

//         }



//      }
// }
