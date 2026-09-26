#Estrutura de repeticao for
#[qtde de repitcoes conehcidas]

#-Sintaxe
#for <variavel> in <sequencia>:
 #   <bloco de codigo>
#-Metodo append()
salarios = []#criando lista vazia
soma = 0

for i in range(4):
    salario = float(input('Salario: R$ '))
    soma += salario
    salarios.append(salario)

media = soma/4
print('--------------------')
print(f'Media salarial: {media}')
print('--------------------')

for salario in salarios:
    if salario < media:
        print(f"Abaixo da media: R$ {salario:.2f}")

"""
Solicite ao usuario o numero de funcionarios
Altere os salarios da lista
Imprima os salarios acima da media
"""

float(input("Digite o numero de funcionarios"))
