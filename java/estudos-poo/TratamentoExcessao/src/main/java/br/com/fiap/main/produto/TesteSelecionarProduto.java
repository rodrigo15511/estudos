package br.com.fiap.main.produto;

import br.com.fiap.dao.ProdutoDao;
import br.com.fiap.entities.Produto;

import java.sql.SQLException;
import java.util.ArrayList;

public class TesteSelecionarProduto {

    public static void main(String[] args) throws SQLException, ClassNotFoundException {

        ProdutoDao dao = new ProdutoDao();

        ArrayList<Produto> listaProduto = (ArrayList<Produto>) dao.selecionar();

        // Se lista for diferente de vazio
        if(listaProduto != null){
            // foreach
            for(Produto p : listaProduto){
                System.out.println(
                        p.getCodigo() + " " +
                        p.getTipo() + " "  +
                        p.getMarca() + " " +
                        p.getPreco() + " "
                );
            }
        }
    }
}
