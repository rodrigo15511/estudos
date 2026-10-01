// using System;

// namespace Aula_7
// {
//     class exercicio1
//     {
//         static void Main(string[] args){
        // Exercicio 1
            // int[] numeros = new int[10];

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine("Insira o numero " + (i + 1) + ": ");
            //     numeros[i] = int.Parse(Console.ReadLine());
            // }

            // int soma = 0; 
            // for (int i = 0; i < 10; i++)
            // {
            //     soma += numeros[i]; 
            // }
            
            // Console.WriteLine($"A soma é {soma}");

            // Exercicio 2
    //         int[,] matriz = {
    // { 1, 2, 3, 4 },
    // { 5, 6, 7, 8 },
    // { 9, 10, 11, 12 },
    // { 13, 14, 15, 16 }
    // };
    //         for(int i = 0; i < matriz.GetLength(0); i++)
    //         {
    //             int soma = 0;
    //             for(int j = 0; j < matriz.GetLength(1); j++)
    //             {
    //                 soma += matriz[i, j]
    //             } 
    //             System.Console.WriteLine($"A soma eh {soma}");   
    //         }  
           // Exercicio 3
        //     int[] vetor = { 1, 2, 3, 2, 1 }; 
        // bool ehPalindromo = true; 

        // for (int i = 0; i < vetor.Length / 2; i++)
        // {
        //     if (vetor[i] != vetor[vetor.Length - 1 - i])
        //     {
        //         ehPalindromo = false;
        //         break; 
        //     }
        // }
        // if (ehPalindromo)
        // {
        //     Console.WriteLine("O vetor eh um palindromo.");
        // }
        // else
        // {
        //     Console.WriteLine("O vetor não eh um palindromo.");
        // }

       // Exercicio 4 
    //     int[,] matriz1 = {
    // { 1, 2, 3, 4 },
    // { 5, 6, 7, 8 },
    // { 9, 10, 11, 12 },
    // { 13, 14, 15, 16 }
    // };
    //     int DiagonalPrincipal = 0;
    //     int DiagonalSecundaria = 0;
    // for(int i = 0; i < matriz1.GetLength(0); i++){
    //     DiagonalPrincipal += matriz1[i, i];
    //     DiagonalSecundaria += matriz1[i, matriz1.GetLength(1)-1 -i];
    // }    
    //         System.Console.WriteLine($"A diagonal principal eh {DiagonalPrincipal} e a secundaria eh {DiagonalSecundaria}. ");

            // Exercicio 5
            int [,] matriz = new int [3, 3]{
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            int[,] transposta = new int[3,3];
            int[,] transposta2 = new int[3,3];

            for (int i = 0; i < matriz.GetLength(0); i++){
                for (int j = 0; j < matriz.GetLength(1); j++){
                    transposta [j, i] = matriz [i, j];
                }
            }

            for (int i = 0; i < transposta.GetLength(0); i++){
                for (int j = 0; j < transposta.GetLength(1); j++){
                    transposta2 [j, i] = transposta [i, matriz.GetLength(0) -1 -j];
                }
            }

            foreach (int i in transposta){
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine();
        }
    } 
}


           