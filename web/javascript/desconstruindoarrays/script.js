//

let pessoa ={
    nome: "Rodrigo",
    sobrenome: "Terra",
    empresa: "nenhuma",
    cargo: "programador"
};

//console.log(pessoa.nome);
//console.log(pessoa.cargo);

// let nome = "teste";

// const{ nome:nomePessoa, cargo, sobrenome, empresa} = pessoa;
// console.log(nomePessoa);
// console.log(sobrenome);

// console.log(cargo);
// console.log(empresa);

//==================
//Destruturação de arrays

let nomes = ["Pedro", "Pablo", "Matheus"];

// let { 0:pedro, 1:henrique } = nomes;
// console.log(pedro);
// console.log(henrique);
let[primeironome, segundonome] = nomes;
console.log(primeironome);