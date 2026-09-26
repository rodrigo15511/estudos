package br.com.fiap.entities;

public class Jogador {
    private String nome;
    private int camisa;
    private double altura;
    private int idade;

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getCamisa() {
        return camisa;
    }

    public void setCamisa(int camisa) {
        this.camisa = camisa;
    }

    public double getAltura() {
        return altura;
    }

    public void setAltura(double altura) {
        this.altura = altura;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    @Override
    public String toString() {
        return "\n\nJogador" +
                "\nnome: " + nome + '\'' +
                "\ncamisa: " + camisa +
                "\naltura: " + altura +
                "\nidade: " + idade;
    }
}
