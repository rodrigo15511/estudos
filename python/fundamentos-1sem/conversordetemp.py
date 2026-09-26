def menu():# aquiu e so o menu, o usuario apenas escolhe a opcao de conversao
    opcao = 0 
    while opcao < 1 or opcao >3: 
        print('--MENU--')
        print('1-Celsius para Fahrenheit')
        print('2- Celsius para Kelvin')
        print('3- Fahrenheit para Celsius')
        opcao = int(input('Escolha uma opcao: '))
    return opcao # sempre tem um return nas funcoes
def entrada_dados(): #aqui ja o usuario escolhe o numero que quer por
    numero = float(input('Digite os numeros: '))
    return numero

def cepfa(c):
    f = (c * 9/5) + 32
    return f 

def cepke(c):
    k = c + 273.15
    return k

def fapce(f):
    c = (f - 32) * 5/9
    return c

def imprimir(resultado):
    print(f'Resultado: {resultado}')

def controlador(opcao, temp):
    if opcao == 1:
        resultado = cepfa(temp)
    elif opcao == 2:
        resultado = cepke(temp)
    elif opcao == 3:
        resultado = fapce(temp)
    else:
        return None    
    return resultado
#main
opcao = menu()
temp = entrada_dados()
resultado = controlador(opcao,temp)
imprimir(resultado)
        



