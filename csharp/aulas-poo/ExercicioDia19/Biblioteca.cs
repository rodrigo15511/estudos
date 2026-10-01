using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDia19
{
    public class Biblioteca
    {
        public string Nome { get; set; }
        public List<Funcionario> Funcionarios = new List<Funcionario>();
        public CatalogoDeLivros Catalogo { get; set; } 
        public Biblioteca(string nome)
        {
            Nome = nome;
            this.Catalogo = new CatalogoDeLivros();
        }
        public void AdicionarLivro(Livro livro)
        {
            Catalogo.Catalogo.Add(livro);
        }
        public void RemoverLivro(Livro livro)
        {
            Catalogo.Catalogo.Remove(livro);
        }
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }
        public void RemoverFuncionario(Funcionario funcionario)
        {
            Funcionarios.Remove(funcionario);
        }
    }
}