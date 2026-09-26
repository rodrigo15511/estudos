def nome_aluno():
    nome = input('Digite o nome do aluno: ')
    return nome

def peso_atual():
    peso = float(input('Digite o peso atual: '))
    return peso

def altura_atual():
    altura = float(input('Digite o altura atual: '))
    return altura

def calc_imc(peso,altura):
    imc = peso / altura ** 2
    return imc

def imprimir_dados(nome,imc):
    print('---imprimindo dados---')
    if imc < 18.5:
        print('Abaixo do peso')
    elif imc < 25.0:
        print('Peso normal')
    elif imc < 30:
        print('Sobrepeso')
    elif imc >= 30.0:
        print('Obesidade')        
    else:
        print('Digite um numero valido! ')
    print(f'Nome: {nome} IMC:{imc}')

# main

nome = nome_aluno()
peso = peso_atual()
altura = altura_atual()
