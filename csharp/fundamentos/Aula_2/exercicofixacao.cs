using System;

namespace areatriangulo
{
    class exerciciosfixacao
    {
        static void Main(string[] args)
{
    System.Console.WriteLine("Digite o seu nome completo: ");
    string nome = Console.ReadLine();
    System.Console.WriteLine("O seu nome completo eh "+ nome);
    
    System.Console.WriteLine("Quantos quartos tem na sua casa? ");
    string quartos = Console.ReadLine();
    System.Console.WriteLine("Tem "+ quartos);

    System.Console.WriteLine("Entre com o preço de um produto: ");
    string preco = Console.ReadLine();
    System.Console.WriteLine("Tem "+ preco);

    System.Console.WriteLine("Entre seu nome, idade e altura: ");
    string linha = Console.ReadLine();
    System.Console.WriteLine("Tem "+ linha.Replace(" ","\n"));
}
    }
}
        