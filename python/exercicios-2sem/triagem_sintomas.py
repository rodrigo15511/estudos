def analisar_lista(lista_sintomas):
    lista_alerta = []
    for sintoma in lista_sintomas:
        if sintoma == "dor no peito":
            lista_alerta.append(sintoma)
        elif sintoma == "falta de ar":
            lista_alerta.append(sintoma)
        elif sintoma == "desmaio":
            lista_alerta.append(sintoma)
        elif sintoma == "sangramento":
            lista_alerta.append(sintoma)
    tamanho_lista = len(lista_alerta)
    return tamanho_lista                
# def contar_lista(lista_sintomas):
#     lista_alerta= ['dor no peito', 'falta de ar','desmaio','sangramento']
#     contador = 0
#     for sintoma in lista_sintomas:
#         if sintoma == lista_alerta:
#             contador += 1
#         return contador

def classificar_urgencia(tamanho_lista):
        if tamanho_lista == 0:
            return 'Sem urgencia'
        elif tamanho_lista == 1:
            return 'Urgente'
        elif tamanho_lista >= 2:
            return 'CORRE'


#main
lista_sintomas = ['tosse','dor de barriga', 'dor no peito']
resultado_contagem = analisar_lista(lista_sintomas)
print(resultado_contagem)

resultado = classificar_urgencia(resultado_contagem)
print(resultado)


