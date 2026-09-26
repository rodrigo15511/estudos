def calcular_media_plantao(nota_p):
    maior_nota = nota_p[0]
    soma_p = 0
    for nota in nota_p:
        if maior_nota < nota:
            maior_nota = nota
        soma_p = soma_p + nota

    soma_real = soma_p - maior_nota
    total_len = len(nota_p) - 1
    media = soma_real/total_len    
    return media


def calcular_casos_clinico(nota_c):
    soma_c = 0
    for nota in nota_c:
        soma_c += nota
    media_c = soma_c / len(nota_c)
    return media_c   

def calcular_modulo(nota_p,nota_c,nota_oc):
    media_plantao = calcular_media_plantao(nota_p)
    media_casos_clinicos = calcular_casos_clinico(nota_c)
    media_final = (media_plantao * 0.25) + (media_casos_clinicos * 0.35) + (nota_oc * 0.40)
    return media_final

#main
plantao_modulo1 = [7.0,3.0,10.0,5.0,8.0]
casos_modulo1 = [4.0,5.0,9.0]
nota_oc_modulo1= 7.0
nota_final_modulo1 = calcular_modulo(plantao_modulo1,casos_modulo1,nota_oc_modulo1)
print(f"A nota final do modulo 1 eh {nota_final_modulo1:.2f}")

plantao_modulo2 = [8.0,5.0,6.0,7.0,8.0]
casos_modulo2 = [4.5,6.5,9.0]
nota_oc_modulo2= 6.5
nota_final_modulo2 = calcular_modulo(plantao_modulo2,casos_modulo2,nota_oc_modulo2)
print(f"A nota do modulo 2 eh {nota_final_modulo2:.2f}")

media_final = (nota_final_modulo1 * 0.4) + (nota_final_modulo2 * 0.6)
print(f"A nota final eh {media_final:.2f}")

