'''
Crie um programa em Python para cadastrar 5 nomes de jogos em uma lista.
O programa deve mostrar todos os jogos cadastrados, permitindo também, adicionar
e remover um novo jogo, e ordenar a lista (jogos). Ao final, exibir a lista
atualizada.
'''
jogos = []

for i in range(5):
    nome = input('Digite 5 nomes de jogos: ')
    jogos.append(nome)

print('Jogos cadastrados: ')
for jogo in jogos:
    print (jogo)

add = input('Adicionar jogos: ')
jogos.append(add)
print(jogos)





