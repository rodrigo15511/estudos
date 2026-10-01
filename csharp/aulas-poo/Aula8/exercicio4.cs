using System;

class Program111
{
    public static int SomaDasDiagonais(int[,] matriz)
    {
        int n = matriz.GetLength(0);
        int somaPrincipal = 0;
        int somaSecundaria = 0;

        for (int i = 0; i < n; i++)
        {
            somaPrincipal += matriz[i, i];
            somaSecundaria += matriz[i, n - 1 - i];
        }

        return somaPrincipal + somaSecundaria;
    }

    static void Main()
    {
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int somaDasDiagonais = SomaDasDiagonais(matriz);
        Console.WriteLine($"A soma das diagonais é: {somaDasDiagonais}");
    }
}
