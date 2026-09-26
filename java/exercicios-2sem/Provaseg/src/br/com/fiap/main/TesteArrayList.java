package br.com.fiap.main;

import br.com.fiap.entities.Jogador;

import javax.swing.*;
import java.util.ArrayList;

public class TesteArrayList {
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
        ArrayList<Jogador> listaJogador = new ArrayList<Jogador>();
        Jogador objJogador = null;
        do{
            objJogador = new Jogador();
            objJogador.setNome(texto("Nome:"));
            objJogador.setIdade(inteiro("Camisa"));
            objJogador.setAltura(real("Altura: "));
            objJogador.setIdade(inteiro("Idade"));
            listaJogador.add(objJogador);
        }while(
                JOptionPane.showConfirmDialog(null,
                        "Quer adicionar mais um jogador? ",
                        "ADICIONAR JOGADOR:",
                        JOptionPane.YES_NO_OPTION,
                        JOptionPane.QUESTION_MESSAGE
                )
                        == 0);

        for(Jogador j: listaJogador) {
            System.out.println(
                    j.toString()
            );
        }
    }
}
