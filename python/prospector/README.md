# Prospector

Ferramenta para encontrar clientes para sites: lê uma lista de empresas, classifica cada uma como **sem site**, **site de terceiro** (Instagram, Linktree, Wix...) ou **site próprio**, testa se o site está no ar e expõe as empresas sem site próprio numa API.

## O que tem aqui

- `src/coleta.py`: lê o CSV e normaliza as URLs (a biblioteca `requests` não completa o `https://` sozinha, como o navegador faz)
- `src/analise.py`: classifica a empresa e verifica se o site responde
- `src/banco.py`: salva e lê as empresas num banco SQLite
- `src/relatorio.py`: gera um relatório em CSV
- `api.py`: API com FastAPI, com as rotas `/empresas` e `/leads`
- [`DIARIO.md`](DIARIO.md): o que aprendi e os erros que me pegaram em cada fase

## Como rodar

```bash
python -m venv .venv
.venv\Scripts\activate
pip install -r requirements.txt

python src/main.py          # classifica as empresas de dados/entrada/empresas.csv
uvicorn api:app --reload    # sobe a API em http://127.0.0.1:8000
```

O CSV incluído tem empresas fictícias.
