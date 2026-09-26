def qtde_alunos():
    print("Quantidade de alunos: ")
    qtde = 0
    while qtde <=0:
        print(f'Qtde de alunos: ')
        if qtde < 1:
            ('Digite um numero valido')
    return qtde

def preencher_notas(qtde):
    print('Preencher notas: ')
    notas = []
    #for i in notas(): #nao utilizar o for i in notas pois a lista esta vazia, nao tem nada pra percorrer.
    for i in range(qtde): #o range(qtde) resolve isso pq ele nao depende de lista - ele gera os numeros do zero ate o qtde
        nota = float(input('Notas: '))
        notas.append(nota)#aqui adiciona as notas a lista que foi criada
    return notas    

def calcular_media(notas,qtde):
    soma = 0
    for nota in notas:
        soma += nota
        media = soma/ len(notas)
    return media    

def alunos_abaixo(notas,media):
    alunos_abaixo = []
    for nota in notas():
        if nota < media:
            alunos_abaixo.append(nota)
    return alunos_abaixo        
    
def mostrar_alunos(alunos_abaixo):
    print(f'Alunos abaixo da media: {alunos_abaixo}')
    return mostrar_alunos

def imprimir_notas(notas):
    for nota in notas:
        print(f'Nota: {nota}')


#main



