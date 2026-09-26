def nome_produto():
    nome = input('Nome do produto: ')
    return nome

def preco_unitario():
    unitario = float(input('Digite o preco unitario'))
    return unitario

def qtde_produto():
    qtde = int(input('Qtde de produto: '))
    return qtde

def desconto():
    sim = 0
    nao = 0
    desconto = input('Cliente possui desconto: sim/nao')
    #if desconto == sim:
       # print('Cliente possui desconto')
    #elif desconto == nao:
        #print('Cliente nao possui desconto')
    #else:
        #print('sim ou nao?')
    return desconto == 'sim'
    return desconto
def calculo_desconto(desconto, unitario, qtde):
    total = unitario * qtde
    if desconto:
        total * 0.10
    return total

def imprimir_cumpom(nome,qtde,total):
    print('---Cupom---')
    print(f'Produto: {nome}')
    print(f'Quantidade: {qtde}')
    print(f'Total: {total}')

nome = nome_produto()
unitario = preco_unitario()
qtde = qtde_produto()



    

    