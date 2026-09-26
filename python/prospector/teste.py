import requests

sites = [
    "https://www.google.com",
    "https://estenegocionaoexiste123456.com.br",
    "https://ranuccibarbearia.gendo.app",
]

for site in sites:
    try:
        resposta = requests.get(site, timeout=5)
        print(f"{site} -> {resposta.status_code}")
    except requests.exceptions.RequestException:
        print(f"{site} -> FALHOU")