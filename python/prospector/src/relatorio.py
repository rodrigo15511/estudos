import csv

def salvar_relatorio(empresas):
    with open("dados/saida/relatorio.csv", "w", encoding="utf-8", newline="") as arquivo:
        escritor = csv.DictWriter(arquivo, fieldnames=["nome", "telefone", "site","url", "situacao", "online", "status"])
        escritor.writeheader()
        for empresa in empresas:
            escritor.writerow(empresa)
        
