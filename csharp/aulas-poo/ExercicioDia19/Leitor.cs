using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDia19
{
    public class Leitor : Usuario
    {
        public Biblioteca Biblioteca { get; set; }
        public Leitor(Biblioteca biblioteca, string nome, string cpf) : base(nome, cpf)
        {
            Biblioteca = biblioteca;
        }
        public CatalogoDeLivros ConsultarLivros()
        {
            return Biblioteca.Catalogo;
        }

    }
}