package br.com.fiap.dao;

import br.com.fiap.conexoes.ConexaoFactory;
import br.com.fiap.entities.Produto;

import java.sql.Connection;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class ProdutoDao {

    public Connection minhaConexao;

    public ProdutoDao() throws SQLException, ClassNotFoundException {
        this.minhaConexao = new ConexaoFactory().conexao();
    }

    // Inserir -> Insert
    public String inserir(Produto produto) throws SQLException {
        PreparedStatement stmt =
                minhaConexao.prepareStatement("Insert Into T_FIAP_Produto values (?,?,?,?)");
        stmt.setInt(1, produto.getCodigo());
        stmt.setString(2, produto.getTipo());
        stmt.setString(3, produto.getMarca());
        stmt.setDouble(4, produto.getPreco());

        stmt.execute();
        stmt.close();

        return "Produto Cadastrado com Sucesso!!!";
    }

    // Deletar -> Delete
    public String deletar(int codigo) throws SQLException {
        PreparedStatement stmt =
                minhaConexao.prepareStatement("Delete From T_FIAP_Produto where CODIGO =?");
        stmt.setInt(1, codigo);

        stmt.execute();
        stmt.close();

        return "Produto Deletado com Sucesso!!!";
    }

    // Atualizar -> UpDate
    public String atualizar(Produto produto) throws SQLException {
        PreparedStatement stmt =
                minhaConexao.prepareStatement
                        ("Update T_FIAP_Produto set TIPO =?, MARCA =?, PRECO =? where CODIGO =?");
        stmt.setString(1, produto.getTipo());
        stmt.setString(2, produto.getMarca());
        stmt.setDouble(3, produto.getPreco());
        stmt.setInt(4, produto.getCodigo());

        stmt.executeUpdate();
        stmt.close();

        return "Produto Atualizado com Sucesso!!!";
    }

    // Selecionar -> Select
    public ArrayList<Produto> selecionar() throws SQLException {
        ArrayList<Produto> listaProduto = new ArrayList<Produto>();
        PreparedStatement stmt =
                minhaConexao.prepareStatement("select * from T_FIAP_PRODUTO");

        ResultSet rs = stmt.executeQuery();

        while (rs.next()) {
            Produto objProduto = new Produto();
            objProduto.setCodigo(rs.getInt(1));
            objProduto.setTipo(rs.getString(2));
            objProduto.setMarca(rs.getString(3));
            objProduto.setPreco(rs.getDouble(4));

            listaProduto.add(objProduto);
        }
        return listaProduto;
    }

    // Selecionar -> buscarPorCodigo
    public Produto buscarPorCodigo(int codigo) throws SQLException {
        Produto produto = null;

        PreparedStatement stmt =
                minhaConexao.prepareStatement("Select * from T_FIAP_PRODUTO where CODIGO=?");
        stmt.setInt(1, codigo);

        ResultSet rs = stmt.executeQuery();

        if (rs.next()) {
            produto = new Produto();
            produto.setCodigo(rs.getInt(1));
            produto.setTipo(rs.getString(2));
            produto.setMarca(rs.getString(3));
            produto.setPreco(rs.getDouble(4));
        }

        rs.close();
        stmt.close();

        return produto;
    }
}
