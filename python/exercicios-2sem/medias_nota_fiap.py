#Função para calcular a média dos CPs (descartando a menor nota)
def calcular_media_checkpoints(notas_cp):
    menor_nota = notas_cp[0]
    soma_total = 0

    #descobrir a menor nota e calcular o somatório das notas
    for nota in notas_cp:
        if nota < menor_nota:
            menor_nota = nota
        soma_total += nota

    soma_notas_validas = soma_total - menor_nota
    media = soma_notas_validas / len(notas_cp)
    return media
#calcular media das sprints
def calcular_media_sprints(notas_sprint):
    soma = 0 #varaivel acmulutativa
    for nota in notas_sprint:
        soma += nota
    media = soma/ len(notas_sprint)
    return media
#funcao para calcular a nota final de 1 semestre
def calc_nota_semestre(notas_cp, notas_sprint, nota_gs):
    media_cp = calcular_media_checkpoints(notas_cp)
    media_sprint = calcular_media_sprints(notas_sprint)
    #aplicaco dos pesos: 20% cp / 20% sprint / 60 % gs
    nota_semestre = (media_cp * 0.2) + (media_sprint * 20) + (nota_gs * 0.60)
    return nota_semestre

#principal(main)
#1o sem
cps_semstre1 = [7.0, 7.0, 10.0]
sprint_semestre1 = [8.0, 10.0]
gs_semestre1 = 7.0

nota_semestre1 = calc_nota_semestre(cps_semstre1,sprint_semestre1,gs_semestre1)

cps_semstre2 = [6.0, 9.0, 10.0]
sprint_semestre1 = [5.0, 10.0]
gs_semestre2 = 7.0

nota_semestre2 = calc_nota_semestre(cps_semstre2,sprint_semestre2,gs_semestre2)

media_final = (nota_semestre1 * 0.4) + (nota_semestre2 * 0.6)
print(f'Nota do 1 semestre: {nota_semestre1}')
print(f'Nota do 2 semestre: {nota_semestre2}')
print(f'Media final {media_final}')
#============================
#Função para calcular a média dos CPs (descartando a menor nota)
def calcular_media_checkpoints(notas_cp):
    menor_nota = notas_cp[0]
    soma_total = 0

    #descobrir a menor nota e calcular o somatório das notas
    for nota in notas_cp:
        if nota < menor_nota:
            menor_nota = nota
        soma_total += nota

    soma_notas_validas = soma_total - menor_nota
    media = soma_notas_validas / (len(notas_cp) - 1)
    return media

#calcular media das sprints
def calcular_media_sprints(notas_sprint):
    soma = 0 #variavel acumulativa
    for nota in notas_sprint:
        soma += nota
    media = soma / len(notas_sprint)
    return media

#funcao para calcular a nota final de 1 semestre
def calc_nota_semestre(notas_cp, notas_sprint, nota_gs):
    media_cp = calcular_media_checkpoints(notas_cp)
    media_sprint = calcular_media_sprints(notas_sprint)
    #aplicacao dos pesos: 20% cp / 20% sprint / 60% gs
    nota_semestre = (media_cp * 0.2) + (media_sprint * 0.2) + (nota_gs * 0.60)
    return nota_semestre

#principal (main)
#1o sem
cps_semestre1 = [7.0, 7.0, 10.0]
sprint_semestre1 = [8.0, 10.0]
gs_semestre1 = 7.0

nota_semestre1 = calc_nota_semestre(cps_semestre1, sprint_semestre1, gs_semestre1)

#2o sem
cps_semestre2 = [6.0, 9.0, 10.0]
sprint_semestre2 = [5.0, 10.0]
gs_semestre2 = 7.0

nota_semestre2 = calc_nota_semestre(cps_semestre2, sprint_semestre2, gs_semestre2)

media_final = (nota_semestre1 * 0.4) + (nota_semestre2 * 0.6)
print(f'Nota do 1 semestre: {nota_semestre1}')
print(f'Nota do 2 semestre: {nota_semestre2}')
print(f'Media final: {media_final}')
#python tutor