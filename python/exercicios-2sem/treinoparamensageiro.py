def contar_letras(texto,letra):
    quantidade = 0
    i = 0
    while i < len(texto):
        if letra == texto[i]:
            quantidade += 1
        i+=1
    return quantidade    

def tirar_espacos(texto):
    i = 0
    resultado = ""
    while i < len(texto):
        if texto[i] != " ":
            resultado += texto[i]
        i += 1
    return resultado

def tem_letra(texto,letra):
            


        

