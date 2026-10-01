// Criando objeto em JS
let carro = {
    marca: "Fiat",
    modelo: "Uno",
    ano: 2020, 
    // Construindo função
    ligar: function() {
        console.log("Carro ligado");
    }
};

console.log(carro);
console.log(carro.toString());
console.log(carro.ligar()); 
carro.ligar();

// Modificar valores dentro do objeto
carro.marca = "Ford";
carro.modelo = "Ka";
console.log(carro);

// Deletando propriedades do objeto
delete carro.ano;
console.log(carro);

// Alguns operadores do objeto 
console.log('marca' in carro); 

console.log(carro.marca);
