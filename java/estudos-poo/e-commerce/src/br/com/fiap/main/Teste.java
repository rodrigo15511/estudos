package br.com.fiap.main;

import br.com.fiap.entities.Usuario;

import java.util.Date; // Não esqueça do import para a data!

public class Teste {
    public static void main(String[] args) {

        // 1. Instanciando a classe (Criando o objeto "cliente1")
        Usuario cliente1 = new Usuario();

        // 2. Preenchendo os dados que vieram de Herança (da classe Pessoa)
        cliente1.setId(101);
        cliente1.setNome("João da Silva");
        cliente1.setCpf("123.456.789-00");

        // 3. Preenchendo os dados específicos do Usuário
        cliente1.setRg("12.345.678-9");
        cliente1.setEndereco("Rua das Flores, 123");
        cliente1.setSenha("senhaSecreta123");
        cliente1.setValorUltimaCompra(250.75);
        cliente1.setDataCadastro(new Date()); // O 'new Date()' pega a data e hora de hoje automaticamente!

        // 4. Testando a saída de dados!
        System.out.println("=== DADOS DO CLIENTE ===");
        System.out.println(cliente1); // Isso vai chamar o seu toString()!
    }
}
