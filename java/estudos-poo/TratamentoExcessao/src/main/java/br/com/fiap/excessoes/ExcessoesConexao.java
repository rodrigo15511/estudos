package br.com.fiap.excecoes;

// É preciso importar o ClassNotFoundException para usá-lo sem o caminho completo
import java.sql.SQLException;

public class ExcecoesConexao extends Exception {

    // Construtor vazio corrigido (sem a palavra 'class')
    public ExcecoesConexao() {
        super();
    }

    public ExcecoesConexao(Exception e) {
        super();

        // Uso do 'instanceof' em vez de comparar Strings
        if (e instanceof ClassNotFoundException) {
            System.out.println("Erro Driver: Sem comunicação com o banco de dados.");
        } else if (e instanceof SQLException) {
            System.out.println("Informações de acesso incorretas, acesso negado.");
        } else {
            System.out.println("Falha desconhecida.");
            e.printStackTrace();
        }
    }
}