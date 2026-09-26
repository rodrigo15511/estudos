package br.com.fiap.entities;

public class Produto {
    private int valor;
    private String descricao;
    private int quantidade;

    public int getValor() {
        return valor;
    }

    public void setValor(int valor) {
        this.valor = valor;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public int getQuantidade() {
        return quantidade;
    }

    public void setQuantidade(int quantidade) {
        this.quantidade = quantidade;
    }

    @Override
    public String toString() {
        return "\n\nProduto: " +
                "\nvalor=" + valor +
                "\ndescricao='" + descricao + '\'' +
                "\nquantidade=" + quantidade;
    }
}
