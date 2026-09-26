import csv
def normalizar_url(endereco):
    endereco = endereco.strip().lower()
    if not endereco:
        return ""
    
    if endereco.startswith(("http://", "https://")):
        return endereco
    return "https://" + endereco

    



def carregar_empresas():
    empresas = []
    with open("dados/entrada/empresas.csv", encoding="utf-8", newline="") as arquivo:
        leitor = csv.DictReader(arquivo)
        for linha in leitor:
            linha["url"] = normalizar_url(linha["site"])
            empresas.append(linha)
    return empresas

if __name__ == "__main__":
    print(normalizar_url("gendo.app"))
    print(normalizar_url("https://loja.com"))
    print(normalizar_url("  LOJA.COM  "))
    print(normalizar_url(""))