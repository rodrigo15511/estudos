import { writeFile } from "fs";

const produto = {
    nome: "Produto",
    preco: 10,
    desconto: 0.2
};

writeFile(__dirname + '/arquivoGerado.json', JSON.stringify(produto), err => {
    console.log(err || 'Arquivo salvo');
});
