// function VerificadorDeNumero(numero){
//     if(numero < 0){
//         console.log("Número negativo");
//     }else if(numero = 0){
//         console.log("Número Neutro");
//     }else{
//         console.log("Número positivo");
//     }
//     console.log(VerificadorDeNumero(10));
// }

// function Numero([...primeiroNumero], Numero){
//     for(i = 0; i < primeiroNumero.length; i ++){
//         if(primeiroNumero[i] === Numero){
//             console.log("Número encontrado");
//             return;
//         }else{
//             console.log("Nao encontrado!");
//         }
//     }
// }

// let primeiroNumero = [1, 2, 3, 4, 5];
// console.log(Numero(primeiroNumero, 1));

//jeito + facil
// function Numero(array, numero) {
//     if (array.includes(numero)) {
//         console.log("Número encontrado");
//     } else {
//         console.log("Não encontrado!");
//     }
// }

//3
const products = [
  { name: 'Maça', price: 2.5 },
  { name: 'Coca cola', price: 8 },
  { name: 'Guarana', price: 5 },
  { name: 'Chocolate', price: 20 }
];
 products.map((preco) => {
    if(preco.price === 20){
        console.log("O produto ${produto.name} custa R$20"); 
    }
 })
 products.filter((preco) => {
    if (preco.price > 8) {
        console.log(preco);
    }
 })