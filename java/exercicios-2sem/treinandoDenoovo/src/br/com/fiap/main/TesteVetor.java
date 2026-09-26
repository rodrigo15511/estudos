package br.com.fiap.main;

import br.com.fiap.entities.Cachorro;

import javax.swing.*;

public class TesteVetor {
    static String texto(String j){
        return JOptionPane.showInputDialog(j);
    }
    static Integer inteiro(String j){
        return Integer.parseInt(JOptionPane.showInputDialog(j));
    }
    static Double real(String j){
        return Double.parseDouble(JOptionPane.showInputDialog(j));
    }

    public static void main(String[] args) {
        Cachorro [] vetorCachorro = new Cachorro[3];
        int indice = 0;
        do{
            vetorCachorro[indice] = new Cachorro();
            vetorCachorro[indice].setNome(texto("Nome: "));
            vetorCachorro[indice].setIdade(inteiro("Idade: "));
            vetorCachorro[indice].setPeso(real("Peso: "));
            indice ++;
        }while(
            JOptionPane.showConfirmDialog(null,
                    "Adicionar mais um cachorro:",
                    "CACHORROS:",
                    JOptionPane.YES_NO_OPTION,
                    JOptionPane.QUESTION_MESSAGE
                    )
        ==0);
        for(int buscar = 0;buscar<indice;buscar++){
            System.out.println(
                vetorCachorro[buscar].toString()
            );
        }

    }

}
