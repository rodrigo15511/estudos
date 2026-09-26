package br.com.fiap.entities;

public class Marca {
    private String nome;
    private String cpf;
    private double val;
    private int ano;

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }

    public double getVal() {
        return val;
    }

    public void setVal(double val) {
        this.val = val;
    }

    public int getAno() {
        return ano;
    }

    public void setAno(int ano) {
        this.ano = ano;
    }

    @Override
    public String toString() {
        return "\n\nMarca" +
                "\nnome='" + nome + '\'' +
                "\ncpf='" + cpf + '\'' +
                "\n val=" + val +
                "\nano=" + ano;
    }
}
