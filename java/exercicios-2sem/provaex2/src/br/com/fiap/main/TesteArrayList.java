package br.com.fiap.main;

import br.com.fiap.entities.Dono;

import javax.swing.*;
import java.util.ArrayList;

public class TesteArrayList {
    static String texto(String j){
        return JOptionPane.showInputDialog(j);
    }
    static Integer inteiro(String j){
        return Integer.parseInt(JOptionPane.showInputDialog(j));
    }
    static Double dobro(String j){
        return Double.parseDouble(JOptionPane.showInputDialog(j));
    }

    public static void main(String[] args) {
        ArrayList<Dono> listaDono = new ArrayList<Dono>();
        Dono objDono = null;
        do{
            objDono = new Dono();
            objDono.setCpf(texto("CPF: "));
            objDono.setCnpj(texto("CNPJ: "));
            objDono.setNome(texto("Nome: "));
            objDono.setIdade(inteiro("idade: "));
            objDono.setPeso(dobro("Peso: "));
            listaDono.add(objDono);
        }while (
                JOptionPane.showConfirmDialog(null,
                        "Adicionar mais algum dono",
                        "DONOS FRANQUIAS",
                        JOptionPane.YES_NO_OPTION,
                        JOptionPane.QUESTION_MESSAGE
                        )
                ==0);
        for(Dono d : listaDono){
            System.out.println(
                    d.toString()
            );
        }

    }
}
