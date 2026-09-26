def decidir(numeros):
    contador_par = 0
    contador_impar = 0
    soma_par = 0
    for numero in numeros:
        if numero % 2 == 0:
            print('O numero e par. ')
            contador_par +=1
            soma_par += numeros
        else:
            print('O numero e impar')
            contador_impar += 1
    return soma_par,contador_impar  
          
    print(contador_par)
    print(contador_impar)

numeros = [112,23,123,44,42]           
#main
saber = decidir(numeros)
print(saber) 
