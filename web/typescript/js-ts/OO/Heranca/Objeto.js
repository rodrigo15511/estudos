//craindo objeto em JS
let carro = {
    marca: "Fiat",
    modelo: "Uno",
    ano : 2020
    //construindo funçao
    //ligar: function() {
        //console.log("Carro ligado");
    //},
};


console.log(carro);
console.log(carro.toString());
console.log(carro.ligar());
carro.ligar();

//modificar valores dentro do objeto
carro.marca = "Ford";
carro.modelo = "Ka";
console.log(carro);

//deletando propriedades do objeto
delete carro.ano;
console.log(carro);

//Alguns operadores do objeto 
console.log('marca' in carro);

console.log('marca' )

