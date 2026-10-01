// Operadores em TS
let a: number = 10;
let b: number = 20;

let totalSoma: number = a + b; // adição
let totalSubtracao: number = a - b; // subtração
let totalMultiplicacao: number = a * b; // multiplicação
let totalDivisao: number = a / b; // divisão
let totalResto: number = a % b; // resto da divisão

console.log(`Soma: ${totalSoma} + Subtração: ${totalSubtracao} + Multiplicação: ${totalMultiplicacao} + Divisão: ${totalDivisao} + Resto: ${totalResto}`);

// Operadores de texto
let nome: string = "Lucas";
let sobrenome: string = "Lima";
let textoConcatenado: string = nome + " " + sobrenome; // concatenação
console.log(textoConcatenado); // Lucas Lima

let textoRepetido: string = "Lucas".repeat(3); // repete o texto
console.log(textoRepetido); // LucasLucasLucas

// Operadores de comparação
let comparacao1: boolean = a == b;
let comparacao2: boolean = a != b;
let comparacao3: boolean = a === b;
let comparacao4: boolean = a !== b;

console.log(`Comparação 1: ${comparacao1} + Comparação 2: ${comparacao2} + Comparação 3: ${comparacao3} + Comparação 4: ${comparacao4}`);

// Operadores de comparação com lógicos
let comparacao5 = a > 0 && b > 0;
let comparacao6 = a < 0 || b < 0;
let comparacao7 = !(a > 0); // negação

console.log(`Comparação 5: ${comparacao5} + Comparação 6: ${comparacao6} + Comparação 7: ${comparacao7}`);

let resultado: string = (a > b) ? "A maior que B" : "B maior que A";
console.log(resultado); // B maior que A

// Operadores de atribuição
let valor: number = 10;
valor += 5;
valor -= 5;
valor *= 5;
valor /= 5;
valor %= 5;
console.log(`Valor: ${valor}`);

// Operador de incremento e decremento
let contador: number = 0;
contador++; // incremento
contador--; // decremento
console.log(contador);

// Operador de Nullish Coalescing
let valorNulo: number | null = null;
let valorDefault: number = valorNulo ?? 10; // se valorNulo for null ou undefined, valorDefault será 10
console.log(`Valor Nulo: ${valorNulo} + Valor Default: ${valorDefault}`);

// Operador de Spread
let numeros: number[] = [1, 2, 3, 4, 5];
let novosNumeros: number[] = [...numeros, 6, 7, 8]; // adiciona novos números ao array
console.log(`Números: ${numeros} + Novos Números: ${novosNumeros}`);

// Operador de Destructuring
let pessoa: { nome: string, idade: number } = { nome: "Lucas", idade: 25 };
let { nome: nomePessoa, idade: idadePessoa } = pessoa; // destructuring

console.log(`Nome: ${nomePessoa} + Idade: ${idadePessoa}`);

// Criar um objeto e como ele pode ser chamado
let objeto: { nome: string; idade: number } = { nome: "Lucas", idade: 25 };

let resultados: { [key: string]: number } = {
    soma: totalSoma,
    subtracao: totalSubtracao,
    multiplicacao: totalMultiplicacao,
    divisao: totalDivisao,
    resto: totalResto,
};

let resultado2: { [key: string]: any} ={
    nome:"Lucas",
    idade: 25,
    ativo: true,
    endereco: {
        rua: "Rua 1",
        numero: 123,
    },
}; 
