package br.com.fiap.main;

import br.com.fiap.entities.Produto;

import javax.swing.*;
import java.util.ArrayList;

public class TesteArrayListWhile {

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

        // controle com valor de zero "0" para iniciar as entradas
        int controle = 0;

        // Laço de repetição          while
        //                            enquanto  / faça
        while (controle == 0) {
            // Entradas
            objProduto = new Produto();
            objProduto.setCodigo(inteiro("Código"));
            objProduto.setTipo(texto("Tipo"));
            objProduto.setMarca(texto("Marca"));
            objProduto.setPreco(real("Preço"));

            // Adiciona produto na lista
            listaProdutos.add(objProduto);

            // controle recebe valor  igual a 0 ao clicar YES ou diferente de 0 ao clicar NO
            controle = JOptionPane.showConfirmDialog(null,
                    "Adicionar mais produto no carrinho?",
                    "CARRINHO DE COMPRAS",
                    JOptionPane.YES_NO_OPTION,
                    JOptionPane.QUESTION_MESSAGE);
        }

        // Saídas utilizando o foreach
        for (Produto p : listaProdutos) {
            System.out.println(
                    p.toString()
            );
        }
    }
}
