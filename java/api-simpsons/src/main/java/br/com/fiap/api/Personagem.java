package br.com.fiap.api;

public class Personagem {
    private int id;
    private Integer age; //nao utilizei o int, para poder retornar null, caso nao souber a idade
    private String birthdate;
    private String description;
    private String gender;
    private String name;
    private String occupation;

    public Personagem() {
    }

    public Personagem(int id, Integer age, String birthdate, String description, String gender, String name, String occupation) {
        this.id = id;
        this.age = age;
        this.birthdate = birthdate;
        this.description = description;
        this.gender = gender;
        this.name = name;
        this.occupation = occupation;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Integer getAge() {
        return age;
    }

    public void setAge(Integer age) {
        this.age = age;
    }

    public String getBirthdate() {
        return birthdate;
    }

    public void setBirthdate(String birthdate) {
        this.birthdate = birthdate;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getGender() {
        return gender;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getOccupation() {
        return occupation;
    }

    public void setOccupation(String occupation) {
        this.occupation = occupation;
    }

    @Override
    public String toString() {
        return "\n\nPersonagem: " +
                "\nid: " + id +
                "\nIdade: "  + age +
                "\nAniversario: " + birthdate +
                "\nDescrição: " + description +
                "\nGênero: " + gender +
                "\nNome: " + name +
                "\nOcupação: " + occupation;
    }
}
