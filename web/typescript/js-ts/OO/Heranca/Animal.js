export class Animal{
    constructor(nome,raca, peso, idade)
    {
        this.nome = nome;
        this.raca = raca;
        this.peso = peso;
        this.idade = idade;
    }

    getNome(){
        return this.nome;
    }
    setNome(nome){
        this.nome = this.nome;
    }

    procriar(){
        console.log("novas vidas");
    }
    mover() {
        console.log("Animal se movendo");
    }
}