 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Aula_14
{
    public class PilhaEncadeada
    {
        class Node
        {
            public int valor;
            public Node? proximo;
        }

        static Node? topo = null;

        static void Empilhar(int valor)
        {
            
            Node novoNode = new Node { valor = valor, proximo = topo };
            topo = novoNode;
        }
        static void Desempilhar()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha vazia!");
                return;
            }
            topo = topo.proximo;
        }
             // Função para ver o topo da pilha sem removê-lo
        static int? VerTopo()
        {
            if (topo != null)
            {
                return topo.valor;
            }
            else
            {
                Console.WriteLine("Erro: Pilha vazia!");
                return null;
            }
        }
        static void Listar()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha vazia!");
                return;
            }
            System.Console.WriteLine("Listando a Pilha");
            Node? atual = topo;
            while (atual != null)
            {
                Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }
        static void Main(string[] args)
        {
            Empilhar(10); 
            Empilhar(20); 
            Empilhar(30); 

            Listar();

            // Ver o topo da pilha sem removê-lo
            int? topoDaPilha = VerTopo();
            if (topoDaPilha != null)
            {
                Console.WriteLine($"Topo da pilha: {topoDaPilha}");
            }

            // Empilhando mais um valor
            Empilhar(40); // Pilha: 40 -> 30 -> 20 -> 10
            Listar();

            // Verificando novamente o topo
            topoDaPilha = VerTopo();
            if (topoDaPilha != null)
            {
                Console.WriteLine($"Topo da pilha: {topoDaPilha}");
            }

            // Desempilhando o topo
            Desempilhar(); // Pilha: 30 -> 20 -> 10
            Listar();
        }
    }
}
