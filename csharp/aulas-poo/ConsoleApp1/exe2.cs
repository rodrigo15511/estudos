using System;

namespace Aula14
{
    public class ListaEncadeada
    {
        class Node
        {
            public int Valor;
            public Node? Proximo;
        }

        static Node? inicio = null;

        static void Inserir(int valor, int posicao)
        {
            Node novonode = new Node { Valor = valor, Proximo = null };

            if (posicao == 1)
            {
                novonode.Proximo = inicio;
                inicio = novonode;
                return;
            }

            Node? atual = inicio;
            int contador = 1;

            while (atual != null && contador < posicao - 1)
            {
                atual = atual.Proximo;
                contador++;
            }

            if (atual == null)
            {
                Console.WriteLine("Erro: posição fora do alcance.");
                return;
            }

            novonode.Proximo = atual.Proximo;
            atual.Proximo = novonode;
        }

        static void Listar()
        {
            Node? atual = inicio;
            Console.WriteLine("Valores da lista:");
            while (atual != null)
            {
                Console.Write(atual.Valor + " -> ");
                atual = atual.Proximo;
            }
            Console.WriteLine("null");
        }

        static bool Contem(int valor)
        {
            Node? atual = inicio;
            while (atual != null)
            {
                if (atual.Valor == valor)
                {
                    return true;
                }
                atual = atual.Proximo;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Inserir(10, 1);
            Inserir(20, 2);
            Inserir(30, 3);

            Console.WriteLine("Lista:");
            Listar();

            int valorParaVerificar = 20;
            bool resultado = Contem(valorParaVerificar);
            Console.WriteLine($"Contém {valorParaVerificar}? {resultado}");

            valorParaVerificar = 40;
            resultado = Contem(valorParaVerificar);
            Console.WriteLine($"Contém {valorParaVerificar}? {resultado}");
        }
    }
}
