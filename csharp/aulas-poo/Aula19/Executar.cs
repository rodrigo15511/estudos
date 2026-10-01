using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula19
{
    public class Executar
    {
        static void Main(string[] args)
        {
            CartaoCredito cartao = new CartaoCredito("1234 3245 3467 4567", DataTime.Now, 100);
            cartao.Pagamento(500);
            cartao.Comprovante();

        }
    }
}