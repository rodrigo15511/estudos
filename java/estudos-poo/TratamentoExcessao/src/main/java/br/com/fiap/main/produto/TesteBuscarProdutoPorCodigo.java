package br.com.fiap.main.produto;

import br.com.fiap.dao.ProdutoDao;
import br.com.fiap.entities.Produto;

import javax.swing.*;
import java.sql.SQLException;

public class TesteBuscarProdutoPorCodigo {

    static int inteiro(String j) {
        return Integer.parseInt(JOptionPane.showInputDialog(j));
    }

    public static void main(String[] args) throws SQLException, ClassNotFoundException {

        Produto objProduto = new Produto();

        ProdutoDao dao = new ProdutoDao();

        objProduto.setCodigo(inteiro("Informe o código do produto para busca"));

        objProduto = dao.buscarPorCodigo(objProduto.getCodigo());

        System.out.println(objProduto);

    }
}
