//Spread Operator
// let primeiros = [1, 2, 3];

// let numeros = [...primeiros, 4, 5, 10];
// console.log(numeros);

// let pessoa ={
//     nome: "Matheus",
//     idade: 40,
//     cidade: "Campo Grande / MS"
// }
// let novaPessoa = {
//     ...pessoa,
//     cargo: "RH",
//     status: "Ativo"
// };
// console.log(novaPessoa);

// function novoUsuario(info){
//     let dados = {
//         ...info,
//         stutus: "Ativo",
//         Inicio: "20/02/2026",
//         codigo: "123"
//     };
//     console.log(dados)
// }

// novoUsuario({ nome: "Jose", cargo:"RH", sobrenome: "Delamadalena"})

//REST OPERATOR

function convidados(...nomes){
    console.log("Lista de Convidados:");
    console.log(nomes);
}
convidados("Matheus", "Pedro", "Tino")

function sorteador(...numeros){
    console.log(numeros);

    const numeroGerado = Math.floor(Math.random() * numeros.length);
    console.log(numeros[numeroGerado]);
}

sorteador(1, 3, 2, 5, 7, 85, 234)