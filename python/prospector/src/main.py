from coleta import carregar_empresas
from analise import classificar, verificar_site
from relatorio import salvar_relatorio

empresas = carregar_empresas()
sem_site = 0
site_proprio = 0
site_terceiro = 0

for empresa in empresas:
    situacao = classificar(empresa)
    empresa["situacao"] = situacao
    resultado = verificar_site(empresa["url"])
    empresa["online"] = resultado["online"]
    empresa["status"] = resultado["status"]
    
    print(f"{empresa['nome']} - {empresa['telefone']} - {situacao}")
    if situacao == "SITE_PROPRIO":
        site_proprio += 1
    elif situacao == "SITE_TERCEIRO":
        site_terceiro += 1
    else:    
        sem_site += 1
        
print(f"Site proprio: {site_proprio}")
print(f"Site terceiro: {site_terceiro}")
print(f"Sem site: {sem_site}")
salvar_relatorio(empresas)
print("Relatório salvo em dados/saida/relatorio.csv")