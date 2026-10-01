using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula21
{
    public class Animalia
    {
        public class Animalia : Taxonomia
    {
        // Contrutor
        public Animalia(string reino, string filo, string classe, string ordem, string familia, string genero, string especie)
            : base("Animalia", filo, classe, ordem, familia, genero, especie)
        {
        }

        public override string ObterDescricao()
        {
            return $"Reino: {Reino}\nFilo: {Filo}\nClasse: {Classe}\nOrdem: {Ordem}\nFamilia: {Familia}\nGenero: {Genero}\nEspecie: {Especie}";
        }
    }
}
        

    
