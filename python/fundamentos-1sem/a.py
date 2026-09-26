soma = 0

salario_0 = float(input("Salario: RS "))
soma += salario_0
salario_1 = float(input("Salario: RS "))
soma += salario_1
salario_3 = float(input("Salario: RS "))
soma += salario_3

media = soma / 4

if salario_0 < media:
    print(f'Salario abaixo da media: R$ {salario_0:.2f}')
if salario_1 < media:
    print(f'Salario abaixo da media: R$ {salario_1:.2f}')
if salario_3 < media:
    print(f'Salario abaixo da media: R$ {salario_3:.2f}')    

media = soma / 4
print('--------------------')
print(f'Media salarial: {media}')
print('--------------------')