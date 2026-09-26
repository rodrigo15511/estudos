# def criar_matriz():
    #tabuleiro_real = [['A','B'],['B','A']]
    #tabuleiro_jogador = [['*','*'],['*','*']]  
    #return tabuleiro_real,tabuleiro_jogador  
import random
def criar_matriz(linhas,colunas):
    alfabeto= ['A','B','C','D','E','F','G','H','I','J']
    total_pares = (linhas * colunas) // 2
    cartas = alfabeto[:total_pares] * 2
    random.shuffle(cartas)

    tabuleiro_real = []
    tabuleiro_jogador = []

    for i in range(linhas):
        linha_real = []
        for j in range(colunas):
            linha_real.append(cartas.pop())
            
        tabuleiro_real.append(linha_real)
        
        tabuleiro_jogador.append(['*'] * colunas)
        
    return tabuleiro_real, tabuleiro_jogador


def jogar_rodada(tabuleiro_real,tabuleiro_jogador):
    limite_linhas = len(tabuleiro_real)-1
    limite_colunas = len(tabuleiro_real[0]) -1
    while True:
        try:
            i = int(input("Digite a linha desejada: ")) -1
            j = int(input("Digite a coluna desejada: ")) -1
            if i < 0 or i>limite_linhas or j < 0 or j>limite_colunas:
                print("Digite um numero correto.")         
                continue
            if tabuleiro_jogador[i][j] != "*":
                print("Nao digite as mesmas posicoes")
                continue
                
            print(tabuleiro_real[i][j])
            
            m = int(input("Digite a linha desejada: ")) -1
            n = int(input("Digite a coluna desejada: ")) -1

            if m < 0 or m > limite_linhas or n < 0 or n > limite_colunas:
                print("Digite um numero correto.")
                continue
            if tabuleiro_jogador[m][n] != "*":
                print("Essa carta ja foi encontrada.")
                continue

            if i == m and j == n :
                print("Tente acessar lugares diferentes!")
                continue
            print(tabuleiro_real[m][n])

            print("\n--Nova Jogada--")

            if tabuleiro_real[i][j] == tabuleiro_real[m][n]:
                print("Voce achou um par!")
                tabuleiro_jogador[i][j] = tabuleiro_real[i][j]
                tabuleiro_jogador[m][n] = tabuleiro_real[m][n]
                return True
            else:
                print("Nenhum par encontrado.Tente novamente!")
                return False
                
        except ValueError:
            print("Digite apenas numeros.")
        


def exibir_jogo(matriz):
    print("--JOGO DA MEMORIA--")
    for linha in matriz:
        print(linha)
        

def main():
    for colunas in range(2,6):
        fase = colunas -1
        print(f"\n===== FASE {fase}: tabuleiro 2x{colunas} =====") 

        pares_encontrados = 0
        secreta, tela = criar_matriz(2,colunas)
        total_pares = len(secreta) * len(secreta[0]) // 2
        exibir_jogo(tela)

        while True:
            acertou = jogar_rodada(secreta,tela)
            exibir_jogo(tela)
            if acertou == True:
                pares_encontrados +=1
                print(f"O numeros de pares encontrados é: {pares_encontrados}")
            if pares_encontrados == total_pares:
                print(f"Fase {fase} concluida!")
                break

    print("\nParabens! Voce completou todas as fases!")


main()