let idade = 18;
//condicao simples
if (idade >= 18) {
    console.log("Você é maior de idade.");
}
//condicao composta
if(idade >= 18) 
{
    console.log("Você é maior de idade.");
}else{
    console.log("Você é menor de idade.");
}

//condicao composta com else  if
if(idade >= 18) 
    {
        console.log("Você é maior de idade.");
    }else if(idade >= 12){
        console.log("Você é adolescente.");
    }else{
        console.log("Você é criança.");
    }

    //condicao ternario
    let podeVotar = (idade >= 18) ? "Você pode votar." : "Você não pode votar.";
    console.log(podeVotar);

    let podeVotar2 = (idade >= 18) ? "Pode votar" : (idade >= 12) ? "Adolescente" :
    "Criança";
    console.log(podeVotar2);

    //condicao switch
    let dia = 5;
    switch (dia) {
        case 1:
            console.log("Domingo");
            break;
        case 2:
            console.log("Segunda");
            break;
        case 3:
            console.log("Terça");
            break;
        case 4:
            console.log("Quarta");
            break;
        case 6:
            console.log("Quinta");
            break;
        case 7:
            console.log("Sexta");
            break;
        default:
                console.log("Dia inválido");
                break;     
    }


