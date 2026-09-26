package br.com.fiap.entities;

public class Remedio {
    private int codigo;
    private  String laboratorio;
    private String nome;
    private String dataFabricacao;
    private String datavalidade;
    private double preco;

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public String getLaboratorio() {
        return laboratorio;
    }

    public void setLaboratorio(String laboratorio) {
        this.laboratorio = laboratorio;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getDataFabricacao() {
        return dataFabricacao;
    }

    public void setDataFabricacao(String dataFabricacao) {
        this.dataFabricacao = dataFabricacao;
    }

    public String getDatavalidade() {
        return datavalidade;
    }

    public void setDatavalidade(String datavalidade) {
        this.datavalidade = datavalidade;
    }

    public double getPreco() {
        return preco;
    }

    public void setPreco(double preco) {
        this.preco = preco;
    }

    @Override
    public String toString() {
        return "\n\nRemedio" +
                "\ncodigo=" + codigo +
                "\nlaboratorio=" + laboratorio + '\'' +
                "\nnome=" + nome + '\'' +
                "\ndataFabricacao=" + dataFabricacao + '\'' +
                "\ndatavalidade=" + datavalidade + '\'' +
                "\npreco=" + preco;
    }
}
