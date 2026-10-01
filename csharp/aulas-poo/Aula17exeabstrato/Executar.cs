using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17exeabstrato
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Assalariado assalariado = new Assalariado("João", "Silva", "123456789", 3000);
        Comissionado comissionado = new Comissionado("Maria", "Oliveira", "987654321", 5000, 0.1);
        Horista horista = new Horista("Carlos", "Santos", "111222333", 50, 160);

        Console.WriteLine($"Assalariado: {assalariado.Nome} {assalariado.Sobrenome}, Vencimento: {assalariado.Vencimento()}");
        Console.WriteLine($"Comissionado: {comissionado.Nome} {comissionado.Sobrenome}, Vencimento: {comissionado.Vencimento()}");
        Console.WriteLine($"Horista: {horista.Nome} {horista.Sobrenome}, Vencimento: {horista.Vencimento()}");
        }
    }
}
