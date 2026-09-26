function geradorNumero(qtdNumeros){
    let numerosGerados = [];
    if(qtdNumeros < 6 || qtdNumeros > 9){
        console.log("Qauntidade invalida");
        return numerosGerados;
    }
    for(let i = 0;i < qtdNumeros;i++){
    let numeroaleatorio = Math.floor(Math.random() * 60) + 1
        if(numerosGerados.includes(numeroaleatorio)){
            console.log("Número repetido, gerando outro...");
            i--;
        }else{
            numerosGerados.push(numeroaleatorio);
        }
    }
    return numerosGerados;
}