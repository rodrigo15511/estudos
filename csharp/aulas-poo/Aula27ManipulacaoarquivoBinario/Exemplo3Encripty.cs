using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Security.Cryptography;


namespace Aula27ManipulacaoarquivoBinario
{
    public class Exemplo3Encripty
    {
        static void Main(string[] args)
        {
        string original = "arquivo_original.txt";
        string encryptFile = "arquivo_ encriptado.txt";   
        string decryFile = "arquivo_ desencriptado.txt";

        //Criar o um arquivo de texto simples
        File.WriteAllText(original, "Este e conteudo do arquivo original");
        System.Console.WriteLine("Arquivo original criado");

        string password = "minhasenhaSegura";


        //metodo p encriptar o arquivo
        EncryptFile(original, encryptFile, password);
        System.Console.WriteLine("Arquivo encriptado");

        EncryptFile(encryptFile, decryFile, password);
        System.Console.WriteLine("Arquivo desencriptado"); 


        }

            static void DecryptFile(string encryptFile, string encryptFile, string password)
            {
                byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32));
                byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16));

                using (Aes aes = aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;

                    using (FileStream inputFileStream = new FileStream(encryptFile, FileMode.Open));
                    using (FileStream outputFileStream = new FileStream(encryptFile, FileMode.Open));
                    using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write));
                    {
                        intputFileStream.CopyTo(cryptoStream);

                    }


                    static void EncryptFile(string original, string encryptFile, string password)
            {
                byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32));
                byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16));

                using (Aes aes = aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;

                    using (FileStream inputFileStream = new FileStream(encryptFile, FileMode.Open));
                    using (FileStream outputFileStream = new FileStream(decrytFile, FileMode.Open));
                    using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Read));
                    {
                        intputFileStream.CopyTo(cryptoStream);
                        
                    }
                    
                    
                    
                }
            }
           
            }
        }
    }
}