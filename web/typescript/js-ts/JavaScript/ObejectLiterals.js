//criar um objeto pareciso com fincao contrutora mas obj literal

function Jogador(nome, idade) {
    //nome = nome;
    this.nome = nome;//outra forma
    this.idade = idade;
    this.chutar = function() {
        console.log(this.nome + " chutou");
    }
}

function Time(nome,qtd)
{
    this.nome = nome;
    this.qtd = qtd;
    this.jogadores = [];
    this.AddJogador = function(jogador) {
        this.jogadores.push(jogador);
    }
}

function compare (obj1, obj2){
    if (obj1 instanceof obj2){
        console.log("Iguais");
    }
    else{
        console.log("Diferentes");
    }
}

let jogador1 = new Jogador("Caça Rato", 30);
let jogador2 = new Jogador("Pablo Vegetti", 35);

let time1 = new Time("Vasco Da Gama", 11);

console.log(jogador2 instanceof Jogador);
