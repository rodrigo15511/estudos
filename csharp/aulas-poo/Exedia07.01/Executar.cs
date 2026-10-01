using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exedia07._01
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Empregado empregado = new Empregado(1000, 2, "Joao");
            Vendedor vendedor = new Vendedor(1000, 2, "Carla", 100);
            GerenteProducao gerente = new GerenteProducao(1000, 2, "Pedro");
            Empregado empregado2 = new Vendedor(1000, 2, "Rodrigo", 1);
            Vendedor vendedor2 = new Vendedor(1000, 2, "Ana Leticia", 100);
            GerenteVendas gerente2 = new GerenteVendas(1000, 2, "Paulo", 100, Regiao.MS);



            List<Empregado> listaEmpregados = new List<Empregado> 
            {
                empregado,
                vendedor,
                gerente,
                empregado2,
                vendedor2,
                gerente2
            };
            Empregado[] vetorEmpregados = listaEmpregados.ToArray();
            Empregados empregados = new Empregados(7, vetorEmpregados);

            empregados.imprime();
            

        }
    }
}