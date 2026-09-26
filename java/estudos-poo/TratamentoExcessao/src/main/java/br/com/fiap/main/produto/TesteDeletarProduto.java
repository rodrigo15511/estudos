package br.com.fiap.main.produto;

import br.com.fiap.dao.ProdutoDao;
import br.com.fiap.entities.Produto;

import javax.swing.*;
import java.sql.SQLException;

public class TesteDeletarProduto {

    static int inteiro(String j) {
        return Integer.parseInt(JOptionPane.showInputDialog(j));
    }

    public static void main(String[] args) throws SQLException, ClassNotFoundException {

        // Instanciar objetos
        Produto objProduto = new Produto();

        ProdutoDao dao = new ProdutoDao();

        objProduto.setCodigo(inteiro("Informe o codigo do produto que será deletado"));

        System.out.println(dao.deletar(objProduto.getCodigo()));
    }
}
