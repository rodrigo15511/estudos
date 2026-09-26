package br.com.fiap.main.produto;

import br.com.fiap.dao.ProdutoDao;
import br.com.fiap.entities.Produto;

import javax.swing.*;
import java.sql.SQLException;

public class TesteAtualizarProduto {

    static String texto(String j) {
        return JOptionPane.showInputDialog(j);
    }

    static int inteiro(String j) {
        return Integer.parseInt(JOptionPane.showInputDialog(j));
    }

    static double real(String j) {
        return Double.parseDouble(JOptionPane.showInputDialog(j));
    }

    public static void main(String[] args) throws SQLException, ClassNotFoundException {

        // Instanciar objetos
        Produto objProduto = new Produto();

        ProdutoDao dao = new ProdutoDao();

        objProduto.setCodigo(inteiro("Informe o codigo do produto que será atualizado"));
        objProduto.setTipo(texto("Tipo"));
        objProduto.setMarca(texto("Marca"));
        objProduto.setPreco(real("Preço"));

        System.out.println(dao.atualizar(objProduto));
    }
}
