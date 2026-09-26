'''
nome1 = input("Digite o seu nome: ")
cidade1 = input("Digite o seu cidade: ")

print(f"Ola sou o {nome1} e moro em {cidade1}")

idade = float(input("Digite sua idade"))
if idade < 12:
    print("Crianca")
elif 12 <= idade <= 18:
    print("Adolescente")
else:
    print("Adulto")
    
numero1 = float(input("Digite o primeiro numero"))
numero2 = float(input("Digite o segundo numero"))

if numero1 > numero2:
    print(f"{numero1} maior")
elif numero2 > numero1:
    print(f"{numero2} maior")
else:
    print("Empate")

numero = 1
while numero <= 10:
    print(f"{numero}")
    numero = numero + 1

pares = 0
numeros = float(input("Digite uns numeros: "))

while numeros != -1:
    if numeros % 2 == 0:
        pares = pares +1
    numeros = float(input("Digite um numeros: "))

print(f"Quantidade de pares: {pares}")
'''
'''
nome = input("Digite o seu nome: ")
cidade = input("Digite a sua cidade: ")
print(f"Ola meu nome eh {nome} e moro em {cidade}")

temperatura = float(input("Digite a temperatura: "))
if temperatura <15:
    print("Frio")
elif 15 <= temperatura <= 25:
    print("Normal")
else:
    print("Calor") 

numeros = int(input("Digite numeros: "))
qtd = 0
soma = 0
while numeros != 0:
    soma = soma + numeros
    qtd = qtd + 1
    numeros = int(input("Digite numeros: "))
print(f"{qtd}")
print(f"{soma}")
'''

impares =1
while impares < 21:
    if impares %2 != 0:
        print(f"{impares}")
    impares = impares + 1 
    
soma_par = 0
soma_impar = 0
maior = 0
num = int(input("Digite numeros ate o -1: "))
while num != -1:
    if num % 2 == 0:
        soma_par = soma_par + num
    elif num % 2 != 0:
        soma_impar = soma_impar + num
    num = int(input("Digite numeros ate o -1: "))

if soma_impar > soma_par:
        print("Soma impar maior")  
elif soma_par > soma_impar:    
        print("Soma par maior") 
else:
     print("Iguais!")
    

print(f"A soma dos numeros pares foi {soma_par}") 
print(f"A soma dos numeros impares foi {soma_impar}") 

