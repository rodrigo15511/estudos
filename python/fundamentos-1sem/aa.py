def qtde_pessoas():
    qtde =int(input('Digite a quantidade de pessoas: '))
    return qtde 
def guardar_idades(qtde):
    idades = []
    for i in range(qtde):
        idade = int(input('Idade: '))
        idades.append(idade)
    return idades

def media_idades(idades):
    soma = 0
    for idade in idades:
        soma = soma + idade
    media = soma/len(idades)
    return media

def acima_media(media,idades):
    acima = []
    contador = 0
    for idade in idades:
    
        if idade > media:
            acima.append(idade)
            contador +=1
    return acima,contador   

qtde = qtde_pessoas()
idades = guardar_idades(qtde) 
media = media_idades(idades)
acima,contador = acima_media(media, idades)
print(media)
print(acima)
print(contador)
