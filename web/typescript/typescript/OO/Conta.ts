import { Pessoa } from "./Pessoa";

export class Conta {
    protected titular: Pessoa; // propriedade protegida
    protected saldo: number; // propriedade protegida

    // Construtor que inicializa as propriedades
    constructor(titular: Pessoa, saldo: number) {
        this.titular = titular;
        this.saldo = saldo;
    }

    // Método para depositar
    public depositar(valor: number): void {
        if (valor <= 0) throw new Error("Valor de depósito deve ser maior que zero.");
        this.saldo += valor;
    }

    // Método para sacar
    public sacar(valor: number): void {
        if (valor <= 0) throw new Error("Valor de saque deve ser maior que zero.");
        if (valor > this.saldo) throw new Error("Saldo insuficiente.");
        this.saldo -= valor;
    }
}

// Classe Poupança, que herda de Conta
export class Poupanca extends Conta {
    private taxaRendimento: number;

    // Construtor da Poupança
    constructor(titular: Pessoa, saldo: number, taxaRendimento: number) {
        super(titular, saldo);
        this.taxaRendimento = taxaRendimento;
    }

    // Método para aplicar rendimento
    public aplicarRendimento(): void {
        this.saldo += this.saldo * (this.taxaRendimento / 100);
    }

    public exibirDados(): string { // override é opcional, mas é uma boa prática
        return `Titular: ${this.titular.getNome()}, Saldo: ${this.saldo}, Rendimento: ${this.taxaRendimento}%`;
    }
} // <-- Fechando corretamente a classe Poupanca

// Classe ContaCorrente, que herda de Conta
export class ContaCorrente extends Conta {
    private limiteChequeEspecial: number;
    
    constructor(titular: Pessoa, saldo: number, limiteChequeEspecial: number) {
        super(titular, saldo);
        this.limiteChequeEspecial = limiteChequeEspecial;
    }
    
    public override sacar(valor: number): void {
        if (valor <= 0) throw new Error("Valor de saque deve ser maior que zero.");
        if (valor > this.saldo + this.limiteChequeEspecial) throw new Error("Saldo insuficiente.");
        this.saldo -= valor;
    }

        public exibirDados(): string { // override é opcional, mas é uma boa prática
        return `Titular: ${this.titular.getNome()}, Saldo: ${this.saldo}, Limite Cheque Especial: ${this.limiteChequeEspecial}`;
    }
}

