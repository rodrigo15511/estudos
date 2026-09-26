from fastapi import FastAPI
from src.banco import listar_do_banco

app = FastAPI()


@app.get("/empresas")
def listar_empresas():
    return listar_do_banco()
        
@app.get("/leads")
def listar_leads():
    empresas = listar_do_banco()
    leads = []
    for empresa in empresas:
        if empresa["situacao"] != "SITE_PROPRIO":
            leads.append(empresa)
    return leads
    
    

@app.get("/")
def raiz():
    return {"mensagem": "funcionou"}


