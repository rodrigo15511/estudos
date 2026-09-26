package br.com.fiap.main;

import br.com.fiap.entities.Dono;

import javax.swing.*;

public class TesteVetorDono {
    static String x(String j){
        return(JOptionPane.showInputDialog(j));
    }
    static Integer y(String j){
        return Integer.parseInt(JOptionPane.showInputDialog(j));
    }
    static Double z(String j){
        return Double.parseDouble(JOptionPane.showInputDialog(j));
    }

    public static void main(String[] args) {
        Dono[] vetorDono = new Dono[4]; //esqueci vetorDono aq
        int indice = 0;

        do {
            vetorDono[indice] = new Dono(); //esqueci do [indice] aq e do vetorDono
            vetorDono[indice].setCpf(x("Cpf: "));
            vetorDono[indice].setCnpj(x("Cnpj: "));
            vetorDono[indice].setNome(x("Nome:"));
            vetorDono[indice].setIdade(y("Idade:"));
            vetorDono[indice].setPeso(z("Peso: "));
            indice ++;
        } while (
                JOptionPane.showConfirmDialog(null,
                        "Adicionar mais um dono",
                        "Adicionar dono",
                        JOptionPane.YES_NO_OPTION,
                        JOptionPane.QUESTION_MESSAGE
                )
                        == 0);
        for (int buscar = 0; buscar < indice; buscar++) {
            System.out.println(
                    vetorDono[buscar].toString()
            );
        }
    }
}
