using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1501
{
    public class Program
    {
        static void Main(string[] args)
        //EG- Meu computador esta estranho, nao consigo dar RUN e esta lento
        

            {        
                string inicioParh = "exercicio.csv";
                 string inputFilePath = "itens.csv";
                string encryptedFile = "arquivo_encriptado.csv";
                string password = "minhaSenhaSegura"; 
                try
                {
                    var items = new List<string>
            {
                "TV UHD, 1000.00, 1",
                "Video Game, 2000.50, 3",
                "Iphone 16, 1600.00, 2",
                "Samsung S21, 1850.00, 2"
            };
             File.WriteAllLines(inputFilePath, items);
            Console.WriteLine($"Arquivo '{inputFilePath}' criado com dados simulados.");
                

                if(!File.Exists(inicioParh))
                {
                    Console.WriteLine("O arquivo de entrada não foi encontrado.");
                    return;
                }

                string[] linhas = File.ReadAllLines(inicioParh);
                
                List<string> linhasFiltradas = new List<string>();
                summaryLines.Add("Nome,Valor Total");

                foreach (string item in line) // percorre todas as linhas
                {
                    System.Console.WriteLine(item);
                }
                 if (columns.Length == 3)
                    {
                        string itemName = columns[0].Trim();
                        double price = double.Parse(columns[1].Trim());
                        int quantity = int.Parse(columns[2].Trim());

                        double totalValue = price * quantity;

                        // Adiciona o nome e valor total no arquivo de resumo
                        summaryLines.Add($"{itemName},{totalValue:F2}");
                    }
                }

                string outputDir = Path.Combine(Path.GetDirectoryName(inputFilePath), "out");
                if (!Directory.Exists(outputDir))
                {
                    Directory.CreateDirectory(outputDir);
                }

                string summaryFilePath = Path.Combine(outputDir, "summary.csv");

                File.WriteAllLines(summaryFilePath, summaryLines);

                Console.WriteLine($"Resumo gerado com sucesso em: {summaryFilePath}");

                EncryptFile(summaryFilePath, encryptedFile, password);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar o arquivo: {ex.Message}");
            }
            
            
        }
        
    static void EncryptFile(string inputFilePath, string outputFilePath, string password)
        {
            byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32));
            byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16));

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv; 

                using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open)) 
                using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create)) 
                using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write)) 
                {
                    inputFileStream.CopyTo(cryptoStream); 
                }





                


        
            


        

        }
    }
}
