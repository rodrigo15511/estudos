def calcular_av_praticas(notas_p):
    menor_nota = notas_p[0]
    soma_p = 0

    for nota in notas_p:
        if nota < menor_nota:
            menor_nota = nota
        soma_p += nota

    soma_nota = soma_p - menor_nota
    quantidade_valida = len(notas_p) - 1
    media = soma_nota/quantidade_valida
    return media

    




