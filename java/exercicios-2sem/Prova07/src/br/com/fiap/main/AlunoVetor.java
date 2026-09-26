package br.com.fiap.main;

import br.com.fiap.entities.Aluno;

import javax.swing.*;

public class AlunoVetor {
    static String texto(String j){
        return JOptionPane.showInputDialog(j);
    }
    static  int inteiro(String j){
        return Integer.parseInt(JOptionPane.showInputDialog(j));
    }
    static double real(String j){
        return Double.parseDouble(JOptionPane.showInputDialog(j));
    }

    public static void main(String[] args) {
        int indice = 0;
        Aluno[] alunoVetor = new Aluno[3];
        do {
            alunoVetor[indice] = new Aluno();
            alunoVetor[indice].setMatricula(inteiro("Matricula: "));
            alunoVetor[indice].setNome(texto("Nome: "));
            alunoVetor[indice].setNota(real("Nota: "));
            indice++;
        }while(JOptionPane.showConfirmDialog(null,
                "Quer Cadastrar mais um aluno: ",
                "CADASTRO DE AUNOS: ",
                JOptionPane.YES_NO_OPTION,
                JOptionPane.QUESTION_MESSAGE
        ) == 0);
        for(Aluno a : alunoVetor){
            System.out.println(
                a.toString()
            );

        }



    }

}
