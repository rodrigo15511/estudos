package br.com.fiap.main;

import br.com.fiap.entities.Marca;

import javax.swing.*;
import java.util.ArrayList;

public class TesteArrayList {
    static String texto(String j){
        return JOptionPane.showInputDialog(j);
    }
    static Integer inteiro(String j){
        return Integer.parseInt(JOptionPane.showInputDialog(j));
    }
    static  Double real(String j){
        return Double.parseDouble(JOptionPane.showInputDialog(j));
    }

    public static void main(String[] args) {
        ArrayList<Marca> listaMarca = new ArrayList<Marca>();
        Marca objMarca = null;
        do{
            objMarca = new Marca();
            objMarca.setCpf(texto("CPF:"));
            objMarca.setNome(texto("Nome: "));
            objMarca.setAno(inteiro("Ano"));
            objMarca.setVal(real("Val|"));
            listaMarca.add(objMarca);
        }while (
             JOptionPane.showConfirmDialog(null,
                     "Add mais marcas",
                     "MARCAS",
                     JOptionPane.YES_NO_OPTION,
                     JOptionPane.QUESTION_MESSAGE
                     )
        ==0);
        for (Marca m : listaMarca){
            System.out.println(
                    m.toString()
            );
        }
    }
}
