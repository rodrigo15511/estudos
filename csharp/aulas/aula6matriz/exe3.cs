using System;

public class HelloWorld
{
    public static void Teste()
    {
        int[,] matriz = {
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 },
    { 13, 14, 15, 16 }
    };
    int maior = matriz[0, 0];
    int menor = matriz[0, 0];
    for(int i =0; i < matriz.GetLength(0); i++){
        for(int j =0; j < matriz.GetLength(0); j++){
            if(matriz[i, j] > maior)
            {
                maior = matriz[i, j];
            }
            if(matriz[i, j] < menor);
            {
                menor = matriz[i, j];
            }
        }             
    }
            int soma = maior + menor;
            Console.WriteLine($"A soma do maior ({maior}) e do menor ({menor}) elemento é: {soma}");
    }
}