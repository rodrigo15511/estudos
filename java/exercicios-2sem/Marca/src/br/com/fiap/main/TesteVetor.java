package br.com.fiap.main;

import br.com.fiap.entities.Marca;

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
        Marca [] vetorMarca = new Marca[5];
        int indice = 0;
        do{
            vetorMarca [indice] = new Marca();
            vetorMarca[indice].setNome(texto("Nome"));
            vetorMarca[indice].setCpf(texto("CPF"));
            vetorMarca[indice].setAno(inteiro("ANO:"));
            vetorMarca[indice].setVal(real("Val"));
            indice ++;
        }while (
             JOptionPane.showConfirmDialog(null,
                     "Quer adicionar uma nova marca?",
                     "MARCAS",
                     JOptionPane.YES_NO_OPTION,
                     JOptionPane.QUESTION_MESSAGE
                     )
        ==0);
        for (int buscar = 0;buscar<indice;buscar++){
            System.out.println(
                    vetorMarca[buscar].toString()
            );
        }
    }

}
