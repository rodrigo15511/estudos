#facil

def analisador_de_numero(numeros):
    numero_par = 0
    numero_impar = 0
    positivo = 0
    negativo = 0
    zero = 0
    for numero in numeros:
        if numero %2 == 0:
            numero_par +=1
        elif numero %2 != 0:
            numero_impar += 1
            return numero_impar,numero_par
        if numero > 0:
            positivo += 1
        elif numero < 0 :
            negativo += 1
        else:
            zero +=1
            return positivo,negativo,zero

        