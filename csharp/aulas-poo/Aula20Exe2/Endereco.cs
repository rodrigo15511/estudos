using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula20Exe2
{
    public class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public Cidade Cidade { get; set; }
        public Endereco(string rua, int numero, string bairro, string cep, Cidade cidade)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
        }
         public string GetRua()
    {
        return Rua;
    }

    public int GetNumero()
    {
        return Numero;
    }

    public string GetBairro()
    {
        return Bairro;
    }

    public string GetCep()
    {
        return Cep;
    }

    public Cidade GetCidade()
    {
        return Cidade;
    }

    }
}