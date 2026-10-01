using System;
namespace Aula14 
{
    public class ListaEncade
    {

    class Node{
        public int Valor;
        public Node? Proximo;
    }
    static Node? inicio = null;

    static void Inserir (int valor)
    {
        //Criando um novo nó com valor fornecido e apontando pro inicio
        Node novonode = new Node {Valor = valor, Proximo = inicio};

        if (inicio == null)
        {
            inicio = novonode;
        }
        else
        {
            Node atual = inicio;
            while(atual.Proximo != null)
            {
                atual = atual.Proximo;
            }
            atual.Proximo = novonode;
        }
    }
        static void Excluir(int valor)
        {
            if(inicio == null) return;/

            if(inicio == null)
            {
                return;
            }
            if(inicio.Valor == valor)
            {
                inicio = inicio.Proximo;
                return;
            }
        }
        static void Listar()
        {
            Node? atual = inicio;
            System.Console.WriteLine("Valores da lista:");
            while(atual != null)
            {
                System.Console.WriteLine(atual.Valor);
                atual = atual.Proximo;
            }

        }

    }

}