#entrada_dados
#entrada_preco
#entrada_qtd
#entrada_desconto
#calc_desconto
#imprimir
#controlador


#A regra é: Precisa de parâmetro quando a função depende de um valor que já existe em outro lugar.
#Não precisa de parâmetro quando a função cria o valor ela mesma.
def entrada_dados():
    nome = input('Digite o nome do produto: ')
    return nome

def entrada_preco():
    preco = float(input('Digite o preco: '))
    return preco
def entrada_qtd():
    qtd = int(input('Digite a qtd'))
    return qtd

def entrada_desconto():
    desconto = input('Voce possui desconto? (sim/nao): ')
    return desconto == 'sim' 

def calc_desconto(preco, qtd,desconto):
    total = preco * qtd
    if desconto:
        total = total * 0.9
    return total    
def imprimir (total,nome, qtd):
    print('----Cupom de desconto----')
    print(f'Nome do produto: {nome} ')
    print(f'Quantidade: {qtd}')
    print(f'Total: {total}')
#main
#para o usuario digitar mais de um produto
continuar = 'sim'
while continuar == 'sim':
    nome     = entrada_dados()
    preco    = entrada_preco()
    qtd      = entrada_qtd()
    desconto = entrada_desconto()
    total    = calc_desconto(preco, qtd, desconto)
    imprimir(nome, qtd, total)
    continuar = input('Adicionar outro produto (sim/nao)')
