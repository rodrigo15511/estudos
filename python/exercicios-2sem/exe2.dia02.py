def media_turma():  
    notas_digitadas = 0
    soma_total = 0
    aluno = input("Digite o nome do aluno: ")
    nota_atual = float(input("Digite a nota do aluno: "))
    while nota_atual >= 0:
        soma_total += nota_atual  
        notas_digitadas +=1 
        print(f"O aluno {aluno} teve a media de {nota_atual}!")
        aluno = input("Digite o nome do proximo aluno: ")
        nota_atual = float(input("Digite a nota do proximo aluno: "))
    
    media = soma_total/notas_digitadas
    print(f"A media da sala foi: {media}")

media_turma()

        