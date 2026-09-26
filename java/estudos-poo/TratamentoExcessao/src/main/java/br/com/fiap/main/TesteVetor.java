package br.com.fiap.main;

import br.com.fiap.entities.Produto;

import javax.swing.*;

public class TesteVetor {

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

        // Laço de repetição          do   / while
        //                            faça / enquanto
        do {
            //Entradas
            vetorProdutos[indice] = new Produto();
            vetorProdutos[indice].setCodigo(inteiro("Código"));
            vetorProdutos[indice].setTipo(texto("Tipo do produto"));
            vetorProdutos[indice].setMarca(texto("Marca"));
            vetorProdutos[indice].setPreco(real("Preço"));

            // Adiciona + 1 no valor do índice
            indice++;

        } while (JOptionPane.showConfirmDialog(null,
                "Adicionar mais produto no carrinho?",
                "CARRINHO DE COMPRAS",
                JOptionPane.YES_NO_OPTION,
                JOptionPane.QUESTION_MESSAGE
        ) == 0);

        // Saídas utilizando o for
        for (int buscar = 0; buscar < indice; buscar++) {
            System.out.println(
                    vetorProdutos[buscar].toString()
            );
        }
    }
}
