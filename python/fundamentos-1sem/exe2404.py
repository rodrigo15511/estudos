nomes = []
vogais = 0
'''
Escreva um programa que leia 5 nomes e armazeneos em uma lisTa. O programa deve imprimir a qtde de nomes q iniciam com vogal
'''
for i in range(5):
    nome = input('Nome: ')
    nomes.append(nome)
print('------')
for nome in nomes:
    print(f'Nome: {nome}')
for nome in nomes:
    if nome[0] == "a" or nome[0] =='e' or nome[0] =='i' or nome[0] =='o' or nome[0] =='u':
        vogais += 1
print(f'{vogais} nomes com vogais')
#FAZER UMA LISTA QUE GUARDE OS NOMES COM VOGAIS