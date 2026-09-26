//while
/*
var x =6;
while(x < 10){
    document.write("<br> O valor do x eh: " + x);


    //Aumentando o valor do X
    x++;
}
*/
//for = para

/*
var valor = 30;
for(a = 1; a < valor;a++){
document.write("<br> O valor do A eh:" + a);
} 
*/

//Switch
function pedir(){
    var valor = prompt("Digite um valor de 1 a 4");
    switch(Number(valor)){
        case 1:
            alert("Suco")
            break;
        case 2:
            alert("Agua")
            break;
        case 3:
            alert("Sorvete")
            break;
        case 4:
            alert("Garcom")
            break;
        default:
            alert("Escolha 1 a 4")   
        break;             
    }
}
//Condicionais
var valor =3;
if(valor == 30){
    console.log("SIM SIM SIM");
}else{
    console.log("DIF DIF MID DIF")
}
var nome = "Matheus";
var userOnline = true;
if(userOnline === false){
    console.log("Matheus e preto")
}else{
    console.log("Ta tranmquilo")
}
if(nome === "Matheus"){
    console.log("TA BOM PRETO")
}
var numero = 10;
numero === 10 ? console.log("Igual a 10") : console.log("Numero diferente")
