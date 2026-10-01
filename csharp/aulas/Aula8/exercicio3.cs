// using System;

// class Program
// {
//     public static bool VerificarPalindromo(int[] vetor)
//     {
//         bool Palindromo = true;
//         for(int i = 0; i < vetor.Length / 2; i++)
//         {
//             if (vetor[i] != vetor[vetor.Length - 1 - i])
//             {
//                 Palindromo = false;
//             } 
//         }
//         return Palindromo;
//     }
//     static void Main(string[] args)
//     {
//         int[] vetor1 = {1, 2, 3, 4, 5};
//         int[] vetor2 = {1 ,2 ,3 ,2 ,1};

//         bool resultado1 = VerificarPalindromo(vetor1);
//         bool resultado2 = VerificarPalindromo(vetor2);
//         System.Console.WriteLine($"o vetor 1 eh {resultado1}");
//         System.Console.WriteLine($"o vetor 2 eh {resultado2}");
//     }
//     }