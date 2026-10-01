class Cachorro extends Animal {
    constructor(nome, raca, peso, idade, cor) {
        super(nome, raca, peso, idade);
        this.cor = cor;
    }

    latir() {
        console.log("LATIR");
    }
}