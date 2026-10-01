using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula26Manipulacaodearquivo
{
    public class Exemplo6
    {
        static void Exe6()
        {
            string inicioParh = @"C:\Users\rodrigoterra\Desktop\teste1.txt";
            System.Console.WriteLine("Directory Separator Char" + Path.DirectorySeparatorChar);
            System.Console.WriteLine("Separador de caminho: " + Path.PathSeparator);
            System.Console.WriteLine("Retorna o diretorio do arquivo" + Path.GetDirectoryName(inicioParh));
            System.Console.WriteLine("Retorna o nome do arquivo" + Path.GetFileName(inicioParh));
            System.Console.WriteLine("Retorna o nome do arquivo sem extensao" + Path.GetFileNameWithoutExtension(inicioParh));
            System.Console.WriteLine("Retorna somente a extensao do arquivo" + Path.GetExtension(inicioParh));;
        }
    }
}