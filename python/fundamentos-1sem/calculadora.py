'''

Calculadora Simples
-menu()
-entrada de dados()
-adicao()
-subtracao()
-divisao()
-multiplicacao()
-imprimir()
-controlador()

'''
def menu():
    opcao = 0
    while opcao < 1 or opcao > 4:      # parênteses são opcionais aqui
        print('---Menu---')
        print('1-Adicao')
        print('2-Subtracao')
        print('3-Multiplicacao')
        print('4-Divisao')
        opcao = int(input('Escolha uma opcao: '))  # dentro do while
        if opcao < 1 or opcao > 4:                 # dentro do while
            print('Opcao invalida, tente novamente!')
    return opcao                        # fora do while — só chega aqui quando válido


def entrada_dados():
    print('---Entrada de dados---')
    numero = int(input('Numeros: '))
    return numero

def adicao(n1,n2):
    print('---Adicao---')
    return n1+n2

def subtracao(n1, n2):
    print('---Subtracao---')
    return n1- n2

def multiplicacao(n1,n2):
    print('---Multiplicacao')
    return n1*n2

def divisao(n1,n2):
    print('---Divisao---')
    return n1/n2

def imprimir(resultado):
    print('---imprimir---')
    print('====================')
    print(f'Resultado: {resultado}')
    print('====================')

def controlador(opcao, n1, n2):
    print('---Controlador---')
    if opcao == 1:
        resultado = adicao(n1,n2)#poderia ser x, y, pois o x saeria copiado o n1, o y n2
    elif opcao == 2:
        resultado = subtracao(n1, n2)
    elif opcao == 3:
        resultado = multiplicacao(n1,n2)
    elif opcao == 4:
        resultado = divisao(n1,n2)
    #else:
        #print('Opcao invalida')
        #return None
    return resultado
    
#Principal - main()
opcao = menu()
n1 = entrada_dados()
n2 = entrada_dados()
resultado = controlador(opcao, n1, n2)
imprimir(resultado)#void, parecido com o print