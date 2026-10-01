using System;

public class Matriz6
{
    static void Main(string[] args)
    {
        int[,] matriz1 = {
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 },
    { 13, 14, 15, 16 }
    };
    int[,] matriz2 = {
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 },
    { 13, 14, 15, 16 }
};
        int[,] matriz3 = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz3[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            for(int i = 0; i<4; i++){
                for(int j= 0; j<4; j++){
                 System.Console.Write($"{matriz3[i,j]} ");   
                }
                System.Console.WriteLine($""); 
            }
    }
}