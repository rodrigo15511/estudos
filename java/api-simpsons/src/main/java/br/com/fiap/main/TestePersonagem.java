package br.com.fiap.main;

import br.com.fiap.api.Personagem;
import br.com.fiap.services.PersonagemService;

import javax.swing.*;
import java.io.IOException;

public class TestePersonagem {
    static String texto(String j) {
        return JOptionPane.showInputDialog(j);
    }

    public static void main(String[] args) throws IOException {
        PersonagemService personagemService = new PersonagemService();
        String id = texto("Digite o id do personagem: ");
        Personagem personagem = personagemService.getPersonagem(id);
        System.out.println(personagem);
    }

}
