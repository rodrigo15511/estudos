using System;

public class AulaMatriz
{
    public static void Teste ()
    {
        int[,] matriz = new int[3, 3]{
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        for (int i = 0; i < matriz.GetLenght(0); i++)
        {
            for (int j = 0; j < matriz.GetLenght(0) ; j++){
               transposta[j, i] = matriz[i, j];
                    System.Console.WriteLine();
                } 
            }
        }
                

                // Ver resultado
                for (int i = 0; i < matriz.GetLenght(0); i++)
                {
                    for (int j = 0; i < matriz.GetLenght(0) ; j++)
                    {
                        System.Console.WriteLine(transposta[i, j] + " ");

                    }
                            System.Console.WriteLine();
    }   
}

        
        

               
