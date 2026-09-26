//Funcoes anonimas

/*
()=> {} Isso eh uma funcao anonima

1-Os parenteses que eh por onde a funcao revere os argumentos
2-"seta" => responsaver pelo nome "arrow"
3- Chaves: o bloco de codigo que representa o corpo da funcao
*/
function somar(a,b){
    let total = a + b;
    return console.log(total);
}
//somar (10,30);

let subtrair = (valor1, valor2) => {
let total = valor1 - valor2;
console.log(total);
}
subtrair (50,20);

let numeros = [1,3,5,10]
numeros.map((item) => {
    console.log(item);
})