let pessoa = {
    nome: "Lucas"
}

let pessoa2 = { 
}

console.log(Object.getOwnPropertyNames(pessoa))//mostra atributos e metodos do objeto

Object.assign(pessoa2,pessoa);

let config = {
    ip: "127.0.0.1",
    port: 3000,
    block: true,
}
let {ip, port, block} = config
console.log(ip, port, block);

let lista = ['Lucas', 'Joaquim', 'João', 'Maria'];
let [nome1, nome2, nome3] = lista;
console.log(nome1, nome2, nome3);

let lista2 = ['Lucas', 'Joaquim', 'João', 'Maria'];
let [nome4, ...resto] = lista2;
console.log(nome4);
console.log(resto);
