package br.com.fiap.main;

import br.com.fiap.api.Endereco;
import br.com.fiap.services.ViaCepServices;

import javax.swing.*;
import java.io.IOException;

public class TesteViaCep {
    static String texto(String j){
        return JOptionPane.showInputDialog(j);
    }
    // Java 21 psvm
    public static void main(String[] args) throws IOException {
        ViaCepServices viaCepServices = new ViaCepServices();
        String cep = texto("Digite o numero do cep: ");
        Endereco endereco = viaCepServices.getEndereco(cep);

        System.out.println(endereco);
    }
}
