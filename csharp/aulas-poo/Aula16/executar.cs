using System;

namespace Aula16
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Carnes carnes1 = new Carnes("Carne Bovina", 20.5, 15);
            Laticinios laticinios1 = new Laticinios("Queijo", 10.0, 30);
            Limpeza limpeza1 = new Limpeza("Sabão", 2.5, 50);
            Ferramentas ferramentas1 = new Ferramentas("Martelo", 15.0, 10);
            Petiscos petiscos1 = new Petiscos("Petisco", 5.0, 25);

            Console.WriteLine($"Produto: {carnes1.Nome}, Preço: {carnes1.Preco}, Estoque: {carnes1.CalcularEstoque()}");
            Console.WriteLine($"Produto: {laticinios1.Nome}, Preço: {laticinios1.Preco}, Estoque: {laticinios1.CalcularEstoque()}");
            Console.WriteLine($"Produto: {limpeza1.Nome}, Preço: {limpeza1.Preco}, Estoque: {limpeza1.CalcularEstoque()}");
            Console.WriteLine($"Produto: {ferramentas1.Nome}, Preço: {ferramentas1.Preco}, Estoque: {ferramentas1.CalcularEstoque()}");
            Console.WriteLine($"Produto: {petiscos1.Nome}, Preço: {petiscos1.Preco}, Estoque: {petiscos1.CalcularEstoque()}");
        }
      double maiorValor = Math.Max(
    carnes1.CalcularEstoque(),
    Math.Max(
        limpeza1.CalcularEstoque(),
        Math.Max(
            petiscos1.CalcularEstoque(),
            Math.Max(
                laticinios1.CalcularEstoque(),
                ferramentas1.CalcularEstoque()
            )
        )
    )
);



    }
}
