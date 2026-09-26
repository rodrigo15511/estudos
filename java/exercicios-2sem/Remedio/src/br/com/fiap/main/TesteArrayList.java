package br.com.fiap.main;

import br.com.fiap.entities.Remedio;

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
        return  Double.parseDouble(JOptionPane.showInputDialog(j));
    }

    public static void main(String[] args) {
        //lista
        ArrayList<Remedio> listaRemedio = new ArrayList<Remedio>();
        //preparar objeto
        Remedio objRemedio = null;
        //laco de repeticao
        do{
            objRemedio = new Remedio();
            objRemedio.setCodigo(inteiro("Codigo"));
            objRemedio.setLaboratorio(texto("Laboratorio"));
            objRemedio.setNome(texto("Nome: "));
            objRemedio.setLaboratorio(texto("Data fabricacao"));
            objRemedio.setDatavalidade(texto("Data validade"));
            objRemedio.setPreco(real("Preco"));
            listaRemedio.add(objRemedio); // pq nao apend
        }while(
                JOptionPane.showConfirmDialog(null,
                        "Quer adicionar mais remedios: ",
                        "REMEDIO",
                        JOptionPane.YES_NO_OPTION,
                        JOptionPane.QUESTION_MESSAGE
                )
                        == 0);

        //saidas
        for(Remedio r : listaRemedio){
            System.out.println(
                r.toString()
            );

        }
    }
}
