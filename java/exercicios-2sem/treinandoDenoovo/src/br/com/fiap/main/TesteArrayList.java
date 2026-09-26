package br.com.fiap.main;

import br.com.fiap.entities.Cachorro;

import javax.swing.*;
import java.util.ArrayList;

public class TesteArrayList {
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
        ArrayList<Cachorro> listaCachorro =new ArrayList<Cachorro>();
        Cachorro objCachorro = null;


    }
}
