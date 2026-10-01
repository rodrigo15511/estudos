type Funcao = (a: number, b: number) => number;

function soma(a: number, b: number): number {
    return a + b;
}
// Arrow function
const somaArrow: Funcao = (a, b) => a + b;

// Função anônima
const somaAnonima: Funcao = function (a, b) {
    return a + b;
};

// Função com retorno implícito
const somaRetornoImplicito: Funcao = (a, b) => a + b;

// Função com parâmetros opcionais
function somaComParametrosOpcionais(a: number, b?: number): number {
    if (b) {
        return a + b;
    }
    return a;
}
console.log(somaComParametrosOpcionais(5)); // 5