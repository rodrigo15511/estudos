export class Pessoa{
    //encapsulamento
    private nome: string;
    private idade: number;

    //construtor
    constructor(nome: string, idade: number) {
        this.nome = nome;
        this.idade = idade;
    }

    public getNome(): string {
        return this.nome;
    }

    public setNome(nome: string): void {
        if(nome.length < 3){
            throw new Error("Nome deve ter mais de 3 caracteres.");
        }
        this.nome = nome;
    }
    public getIdade(): number {
        return this.idade;
    }

    public setIdade(idade: number): void {
        if(idade < 0){
            throw new Error("Idade não pode ser negativa.");
        }
        this.idade = idade;
    }


}