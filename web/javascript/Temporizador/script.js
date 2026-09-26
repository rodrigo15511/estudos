setInterval
function acao(){
    document.write("Executando ação...<br>");
}

// var timer = setInterval(() => {
//     document.write("Executando ação...<br>");
// }, 1000);

setTimeout(acao, 3000);

setTimeout(() => {
    console.log("Executou nosso timeout");
}, 3000);