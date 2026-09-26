package br.com.fiap.entities;
import java.util.ArrayList;
import java.util.Date;
public class Usuario extends Pessoa {
    private String rg;
    private String endereco;
    private String senha;
    private double valorUltimaCompra;
    private Date dataCadastro;
    private ArrayList<Produto> listaProdutos = new ArrayList<Produto>();

    public String getRg() {
        return rg;
    }

    public void setRg(String rg) {
        this.rg = rg;
    }

    public String getEndereco() {
        return endereco;
    }

    public void setEndereco(String endereco) {
        this.endereco = endereco;
    }

    public String getSenha() {
        return senha;
    }

    public void setSenha(String senha) {
        this.senha = senha;
    }

    public double getValorUltimaCompra() {
        return valorUltimaCompra;
    }

    public void setValorUltimaCompra(double valorUltimaCompra) {
        this.valorUltimaCompra = valorUltimaCompra;
    }

    public Date getDataCadastro() {
        return dataCadastro;
    }

    public void setDataCadastro(Date dataCadastro) {
        this.dataCadastro = dataCadastro;
    }

    public ArrayList<Produto> getListaProdutos() {
        return listaProdutos;
    }

    public void setListaProdutos(ArrayList<Produto> listaProdutos) {
        this.listaProdutos = listaProdutos;
    }

    @Override
    public String toString() {
        return super.toString() + "\n\nUsuario{" +
                "\nrg='" + rg + '\'' +
                "\nendereco='" + endereco + '\'' +
                "\nsenha='" + senha + '\'' +
                "\nvalorUltimaCompra=" + valorUltimaCompra +
                "\ndataCadastro=" + dataCadastro +
                "\nlistaProdutos=" + listaProdutos;
    }
}
