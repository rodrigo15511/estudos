#nota = float(input("Digite a sua nota: "))

#while nota != -1:
 #   if nota >= 7:
  #      print("Passou")
 #   elif 5 <= nota <= 6.9:
    #    print("Recuperaçâo")
  #  else:
      #  print("Reprovado")
    #nota = float(input("Digite a sua nota: "))

#print("Fim do programa ")

#seu_nome = input("Digite o seu nome: ")
#seu_idade = int(input("Digite o seu idade: "))
#print(f"Ola {seu_nome}! Voce tem {seu_idade} anos! ")


idade = float(input("Digite sua idade; "))
if idade >= 1:
    print("Numero positivo")
elif idade == 0:
    print("Neutro")
else:
    print("Negativo")

soma = 0
numero = float(input("Digite um numero: "))

while numero != 0:
    soma = soma + numero
    numero = float(input("Digite um numero: "))

print(f"A soma dos numeros foi {soma}")