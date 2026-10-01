using System;

class Program
{
        // Exercicio 1
    // static int Soma(int n)
    // {

    //     if (n == 1){
    //         return 1;
    //     }
    //     else{
    //         return n + Soma (n -1);
    //     }
    // }
    // static void Main(string[] args)
    // {
    //     System.Console.WriteLine("Digite um numero : ");
    //     int n = int.Parse(Console.ReadLine());
    //     if (n <= 0)
    //     {
    //         System.Console.WriteLine("Digite um numero inteiro");    
    //     }
    //     else{
    //         int resultado = Soma(n);
    //         System.Console.WriteLine($"A soma dos numeros {n} eh {resultado}");
    //     }
    // }


     // Exercicio 2
    //  static int Produto(int n)
    //  {
    //     int produto = 1;
    //     for(int i = 1; i <= n; i++)
    //     {
    //         produto *= i;
    //     }
    //     return produto;
    //  }
    //  static void Main(string[] args)
    //  {
    //     System.Console.WriteLine("Digite um numero : ");
    //     int n = int.Parse(Console.ReadLine());

    //     if(n < 1)
    //     {
    //         System.Console.WriteLine("Digite um número maior que um : ");
    //             n = int.Parse(Console.ReadLine());
    //     }
    //     else 
    //     {
    //        int resultado = Produto(n);

    //         System.Console.WriteLine($"O produto dos números de 1 a {n} é: {resultado}");
    //     }

    //  }                       
    
     // Exercicio 3
// static int Potencia(int x, int n)
// {
//     if(n == 0){
//         return 1;
//     }     
//         int resultado = 1;
//         for(int i = 0; i <= n; i++){
//             resultado *= x;
//         }
//         return resultado;
// }
//         static void Main(string[] args)                    
//     {
//         System.Console.WriteLine("Digite um numero inteiro : ");
//         int n = int.Parse(Console.ReadLine());
//         System.Console.WriteLine("Digite outro numero inteiro : ");
//         int x = int.Parse(Console.ReadLine());

//          int resultado = Potencia (x, n);
//          System.Console.WriteLine($"{x} elevado a {n} eh {resultado}");

//     }
// Exercicio 4
    // static int MDC(int a, int b)
    // {
    //     while (b != 0 )
    //     {
    //         int resto = a % b;
    //         a = b;
    //         b = resto;        

    //     }
    //     return a;
    // }
    // static void Main(string[] args)
    // {
    //     System.Console.WriteLine("Digite o primeiro numero : ");
    //     int a = int.Parse(Console.ReadLine());
    //     System.Console.WriteLine("Digite o segundo numero : ");
    //     int b = int.Parse(Console.ReadLine());
        
    //     int mdc = MDC(a, b);

    //     System.Console.WriteLine($"O MDC de  {a} e {b} eh {mdc}");
    // }
          
          
          // Exercicio 5
//         static int Soma(int[] vetor)
//         {
//             int soma = 0;
//             for(int i = 0; i < vetor.Length; i++)
//             {
//                 soma += vetor[i];
//             }
//             return soma;
//         }
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Digite o tamanho do vetor");
//             int tamanho = int.Parse(Console.ReadLine());

//             int[] vetor = new int[tamanho];

//             for(int i = 0; i < vetor.Length; i++)
//             {
//                 System.Console.WriteLine($"Digite o {i + 1}º elemento: ");
//                 vetor[i] = int.Parse(Console.ReadLine());
//             }
//             int soma = Soma(vetor);
//             System.Console.WriteLine($"A soma dos elementos de um vetor de inteiros eh : {soma}");
//         }


     // Exercicio 6
    
//     static int SomaVetor(int[] vetor, int index)
//     {
//         if (index == vetor.Length)
//         {
//             return 0;
//         }
//         return vetor[index] + SomaVetor(vetor, index + 1);
//     }

//     static double CalcularMedia(int[] vetor)
//     {
//         int soma = SomaVetor(vetor, 0);
//         return (double)soma / vetor.Length;
//     }

//     static void Main()
//     {
//         Console.Write("Digite o tamanho do vetor: ");
//         int tamanho = int.Parse(Console.ReadLine());

//         int[] vetor = new int[tamanho];

//         for (int i = 0; i < vetor.Length; i++)
//         {
//             Console.Write($"Digite o {i + 1}º elemento: ");
//             vetor[i] = int.Parse(Console.ReadLine());
//         }

//         double media = CalcularMedia(vetor);
//         Console.WriteLine($"A média dos elementos do vetor é: {media}");
//     }
// }





