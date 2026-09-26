// MAP = Percorrer todo um array

// let lista = ["Matheus", "Jose", "Maria"];

// lista.map((item, index) => {
//     console.log(`PASSANDO: ${item} - Esta na posicao: ${index}`);
// })

//Reduce = busca reduzir um array
let numeros = [5, 3, 2];

let total = numeros.reduce((acumulador, numero, indice, original)=>{
    console.log(`${acumulador} - total ate agora`);
    console.log(`${numero} - valor atual`);
    console.log(`${indice} - indice atual`);
    console.log(`${original} - array original`);
    console.log('------------------');
    return acumulador += numero;
})
console.log(total);