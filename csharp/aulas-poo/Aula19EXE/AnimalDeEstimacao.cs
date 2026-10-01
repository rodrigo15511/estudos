using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula19EXE
{
    public interface AnimalDeEstimacao
    {
        string getNome();
        void setNome(string nome);
        void brincar();
    }
}