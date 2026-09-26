package br.com.fiap.main;
import br.com.fiap.entities.Endereco;
import br.com.fiap.entities.Cliente;

import java.sql.SQLOutput;

public class TesteSistema {
    //metodo de execucao
    public static void main(String[] args) {
        //instanciar objtos
        Cliente objCliente = new Cliente();
        Endereco objEndereco = new Endereco();
        //entradas
        objCliente.setNome("Rodrigo");
        objCliente.setCpf("123.456.789.12");
        objCliente.setIdade(11);
        objCliente.setAltura(1.79);

        objEndereco.setLogradouro("Rua Exemplo");
        objEndereco.setNumero(123);
        objEndereco.setComplemtento("Apto 10");
        objEndereco.setCep("01234-567");
        objEndereco.setBairro("Centro");
        objEndereco.setCidade("São Paulo");

        // Saídas
        System.out.println(
                "Nome: " + objCliente.getNome() +
                        "\nCPF: " + objCliente.getCpf() +
                        "\nIdade: " + objCliente.getIdade() +
                        "\nAltura: " + objCliente.getAltura() +

                        "\n\nEndereço\nLogradouro: " + objCliente.getEndereco().getLogradouro() +
                        "\nNumero: " + objCliente.getEndereco().getNumero() +
                        "\nComplemento: " + objCliente.getEndereco().getComplemento() +
                        "\nCEP: " + objCliente.getEndereco().getCep() +
                        "\nBairro: " + objCliente.getEndereco().getBairro() +
                        "\nCidade: " + objCliente.getEndereco().getCidade()
        );
    }
}
