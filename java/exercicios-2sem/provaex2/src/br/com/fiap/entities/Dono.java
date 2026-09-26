package br.com.fiap.entities;

public class Dono {
    private  String cpf;
    private String cnpj;
    private String nome;
    private int idade;
    private double peso;

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }

    public String getCnpj() {
        return cnpj;
    }

    public void setCnpj(String cnpj) {
        this.cnpj = cnpj;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }

    @Override
    public String toString() {
        return "\n\nDono:" +
                "\ncpf: " + cpf + '\'' +
                "\ncnpj: " + cnpj + '\'' +
                "\nnome: " + nome + '\'' +
                "\nidade: " + idade +
                "\npeso: " + peso;
    }
}
