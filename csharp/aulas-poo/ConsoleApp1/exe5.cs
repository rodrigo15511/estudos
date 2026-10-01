using System;

namespace Aula_14
{
    public class OAasdasda
    {
        class Node
        {
            public int valor;
            public Node? proximo;
        }

        public Node? inicio = null;
        static Node? fim = null;
        static int contador = 0;

        public static void Enfileirar(int valor)
        {
            Node novoNode = new Node { valor = valor, proximo = null };

            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                fim!.proximo = novoNode;
            }

            fim = novoNode;
            contador++;
        }

        static void Desenfileirar()
        {
            if (inicio == null)
            {
                Console.WriteLine("Fila vazia!");
                return;
            }

            Console.WriteLine($"Desenfileirando {inicio.valor}");

            inicio = inicio.proximo;

            if (inicio == null)
            {
                fim = null;
            }

            contador--;
        }

        public static void InserirDeOutraFila(FilaEncadeada outraFila)
        {
            Node? atual = outraFila.inicio;
            
            while (atual != null)
            {
                Enfileirar(atual.valor);
                atual = atual.proximo;
            }
        }

        public static void Listar()
        {
            if (inicio == null)
            {
                Console.WriteLine("Fila vazia!");
                return;
            }

            Console.WriteLine("Listando a Fila:");
            Node? atual = inicio;
            while (atual != null)
            {
                Console.Write(atual.valor + " -> ");
                atual = atual.proximo;
            }
            Console.WriteLine("null");
        }

        static void Main()
        {
            Enfileirar(10);
            Enfileirar(20);
            Enfileirar(30);
            Console.WriteLine("Fila 1:");
            Listar();

            FilaEncadeada fila2 = new FilaEncadeada();
            fila2.Enfileirar(40);
            fila2.Enfileirar(50);

            Console.WriteLine("Fila 2:");
            fila2.Listar();

            InserirDeOutraFila(fila2);

            Console.WriteLine("Fila 1 após inserção de Fila 2:");
            Listar();
        }
    }
}
