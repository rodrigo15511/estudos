using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDia19
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca("Biblio01");

            Funcionario func1 = new Funcionario ("Pedro","Bibliotecário","890.456.789-00"); 
            Funcionario func2 = new Funcionario ("Cesar","Ajudante","923.954.321-00"); 
            biblioteca.AdicionarFuncionario(func1); 
            biblioteca.AdicionarFuncionario(func2);


            Livro livro1 = new Livro ("Harry Potter","JK Rollen", 1954,5 ); 
            Livro livro2 = new Livro ("Diario De Um banana","David Marchen", 1949,3); 
            biblioteca.AdicionarLivro(livro1); 
            biblioteca.AdicionarLivro(livro2);

            Console.WriteLine("Funcionários da Biblioteca:"); 
            foreach (var func in biblioteca.Funcionarios) 
            { 
                Console.WriteLine($"Nome: {func.Cargo}, Cargo: {func.Nome}");
            }

            Console.WriteLine("\nCatálogo de Livros:"); 
            foreach (var livro in biblioteca.Catalogo.Catalogo) 
            { 
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Exemplares Disponíveis: {livro.NumDisponivel}"); 
            }
        }
    }
}