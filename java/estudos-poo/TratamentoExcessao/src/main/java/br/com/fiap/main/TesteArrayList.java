package br.com.fiap.main;

import br.com.fiap.entities.Produto;

import javax.swing.*;
import java.util.ArrayList;

public class TesteArrayList {

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

        // Preparar lista
        ArrayList<Produto> listaProdutos = new ArrayList<Produto>();

        // Preparar objeto
        Produto objProduto = null;

        // Laço de repetição          do   / while
        //                            faça / enquanto
        do {
            //Entradas
            objProduto = new Produto();
            objProduto.setCodigo(inteiro("Código"));
            objProduto.setTipo(texto("Tipo"));
            objProduto.setMarca(texto("Marca"));
            objProduto.setPreco(real("Preço"));

            listaProdutos.add(objProduto);

        } while (JOptionPane.showConfirmDialog(null,
                "Adicionar mais produto no carrinho?",
                "CARRINHO DE COMPRAS",
                JOptionPane.YES_NO_OPTION,
                JOptionPane.QUESTION_MESSAGE
        ) == 0);

        // Saídas utilizando o foreach
        for (Produto p : listaProdutos) {
            System.out.println(
                    p.toString()
            );
        }
    }
}
