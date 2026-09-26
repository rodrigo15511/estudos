#def diga_ola():
    #nome = '1tdspf'
    #print(f'ola, {nome}')

def diga_ola(nome):
     print(f'Ola, {nome}')

def obter_nome():
    nome = input('Nome: ')
    return nome
#main - principal
i = 1
while i <=3:
    nome = obter_nome()
    diga_ola(nome)
    i+=1
