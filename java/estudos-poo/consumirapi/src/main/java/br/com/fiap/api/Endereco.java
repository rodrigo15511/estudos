package br.com.fiap.api;

public class Endereco {

    private String cep;
    private String lorgaoduro;
    private String bairro;
    private String localidade;
    private  String uf;
    private String estado;
    private String regiao;

    public Endereco() {
    }

    public String getCep() {
        return cep;
    }

    public void setCep(String cep) {
        this.cep = cep;
    }

    public String getLorgaoduro() {
        return lorgaoduro;
    }

    public void setLorgaoduro(String lorgaoduro) {
        this.lorgaoduro = lorgaoduro;
    }

    public String getBairro() {
        return bairro;
    }

    public void setBairro(String bairro) {
        this.bairro = bairro;
    }

    public String getLocalidade() {
        return localidade;
    }

    public void setLocalidade(String localidade) {
        this.localidade = localidade;
    }

    public String getUf() {
        return uf;
    }

    public void setUf(String uf) {
        this.uf = uf;
    }

    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
    }

    public String getRegiao() {
        return regiao;
    }

    public void setRegiao(String regiao) {
        this.regiao = regiao;
    }

    @Override
    public String toString() {
        return "\nEndereco" +
                "\ncep:" + cep + '\'' +
                "\nlorgaoduro:" + lorgaoduro + '\'' +
                "\nbairro:" + bairro + '\'' +
                "\nlocalidade:" + localidade + '\'' +
                "\nuf:" + uf + '\'' +
                "\nestado:" + estado + '\'' +
                "\nregiao:" + regiao + '\'';
    }
}
