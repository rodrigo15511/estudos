import { Pessoa } from "./Pessoa";
import { ContaCorrente, Poupanca } from "./Conta";

function main() {
    try {
        const cliente1 = new Pessoa("João", 30);
        const cliente2 = new Pessoa("Maria", 25);

        const contaCorrente = new ContaCorrente(cliente1, 1000, 500);
        const contaPoupanca = new Poupanca(cliente2, 2000, 0.5);

        contaCorrente.depositar(500);
        contaCorrente.sacar(200);
        contaCorrente.exibirDados();
        contaPoupanca.aplicarRendimento();
        contaPoupanca.sacar(100);
        contaPoupanca.exibirDados();
        
    }
    catch (error: any) {
        console.error("Erro", error.message);
    }
}

main();