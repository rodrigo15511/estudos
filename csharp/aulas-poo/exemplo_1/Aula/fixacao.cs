using System;
namespace fIXAÇAO
{
    internal class Program
    {
        static void Main(String[]args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo =5290;
            char genero= 'M';

            double preco1= 2100.0;
            double preco2 = 650.50;
            double preco3 = 53.234567;

            Console.WriteLine($"Produtos :");
            Console.WriteLine($"{produto1}, cujo o preço eh {preco1}");
            Console.WriteLine($"{produto2}, cujo preço eh {preco2}");
            Console.WriteLine($"Registro: {idade} anos, Código: {codigo}, Gênero: {genero}");
            Console.WriteLine($"Media da casa com oito casas decimais:{preco3}");
            Console.WriteLine($"Arredondando tres casa decimais{preco3:F8}");
        }
    }
}