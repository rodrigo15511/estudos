package br.com.fiap.main;

import br.com.fiap.entities.Remedio;

import javax.swing.*;

public class TesteVetor {
    static String texto(String j){
        return JOptionPane.showInputDialog(j);
    }
    static Integer inteiro(String j){
        return Integer.parseInt(JOptionPane.showInputDialog(j));
    }
    static Double real(String j){
        return  Double.parseDouble(JOptionPane.showInputDialog(j));
    }

    public static void main(String[] args) {
        Remedio [] vetorRemedios = new Remedio[4];
        int indice = 0;

        do{
            vetorRemedios[indice] = new Remedio();
            vetorRemedios[indice].setCodigo(inteiro("Codigo: "));
            vetorRemedios[indice].setLaboratorio(texto("Laboratorio: "));
            vetorRemedios[indice].setNome(texto("Nome:"));
            vetorRemedios[indice].setDataFabricacao(texto("Data fabricacao:"));
            vetorRemedios[indice].setDatavalidade(texto("Data validade:"));
            vetorRemedios[indice].setPreco(real("Preco: "));
            indice ++;
        }while(
                JOptionPane.showConfirmDialog(null,
                "Quer adicionar mais remedios: ",
                "REMEDIO",
                        JOptionPane.YES_NO_OPTION,
                        JOptionPane.QUESTION_MESSAGE
                )
        == 0);
        for (Remedio r : vetorRemedios){
            System.out.println(
                    r.toString()
            );
        }
    }
}
