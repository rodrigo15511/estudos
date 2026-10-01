using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exedia07._01
{
    public interface Gerente
    {
        public void autorizar();
        public bool concedeAumento();
        public bool autorizarLicencas();
    }
}