using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula16Herança
{
    public class animal
    {
        public bool Vivo;
        public virtual Animal(bool Vivo)
        {
            this.Vivo = Vivo;
        }
    }
}