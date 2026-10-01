using System;
namespace Aula9{
    class Program
    {
        static int ParOuImpar (int num)
        {
            if (num %2 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
            static void Pi() // Pode puxar ela pelo cw tab
            {
                // return 3,14;
                System.Console.WriteLine("3,14");
            }                   

            static string ParOuImpar(double num){
                if (num % 2 == 0){
                    return Par;
                }
                else
                {
                    return Impar;
                }
            }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um numero: ");
            int num = int.Parse(Console.WriteLine());

            System.Console.WriteLine("Numero eh: " + ParOuImpar (num));
        }
    }
}
