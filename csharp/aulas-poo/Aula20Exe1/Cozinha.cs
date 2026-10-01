using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula20Exe
{
    public class Cozinha
    {
        //Vou utilizar Agregaçao com o objeto PortaCozinha
                //propriedades
        public PortaCozinha PortaCozinha { get; set; }
        public bool Americana { get; set; }
        public float MetragemQuadrada{ get; set; }

        public Cozinha(bool americana, float metragemQuadrada)
        {
            Americana = americana;
            MetragemQuadrada = MetragemQuadrada;
        }
        public void Entrar (PortaCozinha Portacozinha)
        {
            Console.WriteLine("Entrou pela porta da cozinha" + portaCozinha.Cor +
                              "Largura: " + portaCozinha.Largura +
                              "Altura: " + portaCozinha.Altura +
                              "Peso: " + portaCozinha.Peso);
        
        }
    }
}