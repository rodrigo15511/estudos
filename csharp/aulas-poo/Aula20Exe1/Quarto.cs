using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula20Exe
{
    public class Quarto
    {
        // Propriedades
        public PortaQuarto PortaQuarto { get; set; }
        public bool Banheiro { get; set; }
        public float MetragemQuadrada { get; set; }
        //Construtor, vai ter uma relaçao de composiçao com portaquarto
         public Quarto(bool banheiro, float metragemQuadrada)
        {
            Banheiro = banheiro;
            MetragemQuadrada = metragemQuadrada;
            // Aqui estou instanciando a porta do quarto por estar tendo relação de Composição
            PortaQuarto = new PortaQuarto("Branca", 0.80f, 2.10f, 10.0);
        }
    }
}