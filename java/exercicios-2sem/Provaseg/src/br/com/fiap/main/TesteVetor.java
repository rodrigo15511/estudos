package br.com.fiap.main;

import br.com.fiap.entities.Jogador;

import javax.swing.*;

public class TesteVetor {
    static String texto(String j){
        return JOptionPane.showInputDialog(j);
    }
    static int inteiro(String j){
        return Integer.parseInt(JOptionPane.showInputDialog(j));
    }
    static double real(String j){
        return  Double.parseDouble(JOptionPane.showInputDialog(j));
    }

    public static void main(String[] args) {
        Jogador [] vetorJogador = new Jogador[3];
        int indice = 0;

       do{
           vetorJogador[indice] = new Jogador();
           vetorJogador[indice].setNome(texto("Nome: "));
           vetorJogador[indice].setCamisa(inteiro("Camisa: "));
           vetorJogador[indice].setAltura(real("Altura: "));
           vetorJogador[indice].setIdade(inteiro("Idade: "));
           indice ++;
       }while(
               JOptionPane.showConfirmDialog(null,
                       "Quer adicionar mais um jogador? ",
                       "ADICIONAR JOGADOR:",
                       JOptionPane.YES_NO_OPTION,
                       JOptionPane.QUESTION_MESSAGE
                       )
                == 0);
       for(int buscar = 0;buscar< indice;buscar++){
           System.out.println(
                   vetorJogador[buscar].toString()
           );
       }


    }
}
