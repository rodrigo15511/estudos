const array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
// ou um array instanciado
const array2 = new Array(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
//assinando valores a um array
console.log(array[6]); //7

console.log(array[0]); //1
array[0] = 10;

//operando o array com funçoes
array.push(11); //adiciona um elemento no final do array
array.unshift(0); //adiciona um elemento no começo do array
array.pop(); //remove o ultimo elemento do array
array.shift(); //remove o primeiro elemento do array
array.splice(2, 1); //remove o elemento na posiçao 2 do array


