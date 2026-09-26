package br.com.fiap.main;

import br.com.fiap.entities.Produto;

import javax.swing.*;

public class TesteVetorWhile {

    static String texto(String j) {
        return JOptionPane.showInputDialog(j);
    }

    static int inteiro(String j) {
        return Integer.parseInt(JOptionPane.showInputDialog(j));
    }

    static double real(String j) {
        return Double.parseDouble(JOptionPane.showInputDialog(j));
    }

    public static void main(String[] args) {

        // vetor de produtos determina a quantidade máxima de produtos
        Produto[] vetorProdutos = new Produto[3];  // [0] [1] [2]

        // indice para controlar a alocação de produtos nos vetores
        int indice = 0;    // indice++

        // controle com valor de zero "0" para iniciar as entradas
        int controle = 0;

        // Laço de repetição          while
        //                            enquanto  / faça
        while (controle == 0) {
            //Entradas
            vetorProdutos[indice] = new Produto();
            vetorProdutos[indice].setCodigo(inteiro("Código"));
            vetorProdutos[indice].setTipo(texto("Tipo do produto"));
            vetorProdutos[indice].setMarca(texto("Marca"));
            vetorProdutos[indice].setPreco(real("Preço"));

            // Adiciona + 1 no valor do índice
            indice++;

            // controle recebe valor  igual a 0 ao clicar YES ou diferente de 0 ao clicar NO
            controle = JOptionPane.showConfirmDialog(null,
                    "Adicionar mais produto no carrinho?",
                    "CARRINHO DE COMPRAS",
                    JOptionPane.YES_NO_OPTION,
                    JOptionPane.QUESTION_MESSAGE
            );
        }

        // Saídas utilizando o for
        for (int buscar = 0; buscar < indice; buscar++) {
            System.out.println(
                    vetorProdutos[buscar].toString()
            );
        }
    }
}
