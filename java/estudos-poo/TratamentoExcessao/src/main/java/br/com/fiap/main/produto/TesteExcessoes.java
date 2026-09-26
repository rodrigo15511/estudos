package br.com.fiap.main.produto;

import javax.swing.*;


public class TesteExcessoes {
    static String texto(String j) {
        return JOptionPane.showInputDialog(j);
    }

    static int inteiro(String j) {
        return Integer.parseInt(JOptionPane.showInputDialog(j));
    }

    static double real(String j) {
        return Double.parseDouble(JOptionPane.showInputDialog(j));
    }
    public static void main(String[] args) {
        try {
            double dividendo = real("Informe o numero dividendo");
            int divisor = inteiro("Informe o numero divisor");

            double resultado = dividendo / divisor;
            System.out.print("Resultado: " + resultado);
        } catch (NumberFormatException e) {
            System.out.println("Erro aritmetico");
        }catch (ArithmeticException e){
            System.out.println("Erro aritmetico:Não pode ser 0 ");
        }catch (Exception e){
            System.out.println("Erro desconhecido!");
            e.printStackTrace();
        }

    }
}
