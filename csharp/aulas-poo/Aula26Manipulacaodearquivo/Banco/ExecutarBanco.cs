using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace Aula26Manipulacaodearquivo.Banco
{
    public class ExecutarBanco
    {
        static void Main(string[] args)
        {
            var cliente = new Customer("Rodrigo");
            varcontaCorrente = new CurrentAccount(1234, cliente, 300);
            var contaPoupanca = new SavingAccount(5421, cliente, 0.01);

            contaCorrente.Depositar(100);
            contaCorrente.Sacar(50);

            contaPoupancaPoupanca.Depositar(500);
            contaPoupanca.AplicarRendimento();

            //Geracai de excel
            GerarExcel(new List<Account> { contaCorrente, contaPoupanca });
        }
        public static void GerarExcel(List<Account> contas)
        {
            // geracao excel
            //instalar ClosedXML
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.AddWorksheet("Contas Bancarias");

                worksheet.Cell(1,1).Value = "Numero da Conta";
                worksheet.Cell(1,2).Value = "Numero do Cliente";    
                worksheet.Cell(1,3).Value = "Tipo de Conta";    
                worksheet.Cell(1,4).Value = "Saldo";

                int row = 2;
                foreach (var item in contas)
                {
                    worksheet.Cell(row,1).Value = item.Numero.Conta;
                    worksheet.Cell(row,2).Value = item.Cliente.Nome;
                    worksheet.Cell(row,3).Value = item.TipoConta.ToString();
                    worksheet.Cell(row,3).Value = item.Saldo;
                    row++;                    

                }   

                workbook.SaveAs("ContasBancarias.xlsx");
                System.Console.WriteLine("Arquivo gerado com sucesso");
            }
        }
    }
}