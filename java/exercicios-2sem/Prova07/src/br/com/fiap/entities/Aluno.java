package br.com.fiap.entities;

public class Aluno {
    int matricula ; // número inteiro
    String nome;
    double nota;

    public int getMatricula() {
        return matricula;
    }

    public void setMatricula(int matricula) {
        this.matricula = matricula;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public double getNota() {
        return nota;
    }

    public void setNota(double nota) {
        this.nota = nota;
    }

    @Override
    public String toString() {
        return "\n\n Aluno" +
                "\nmatricula=" + matricula +
                "\nnome='" + nome + '\'' +
                "\nnota=" + nota;
    }
}
