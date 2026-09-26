import requests

def verificar_site(url):
    if not url:
        return {"online": False, "status": None}
    try:
        resposta = requests.get(url, timeout=5)
        return{"online": True, "status": resposta.status_code}
    except requests.exceptions.RequestException:
        return {"online": False, "status": None}
    


PLATAFORMAS = [
    "gendo.app",
    "canva.site",
    "wixsite.com",
    "linktr.ee",
    "instagram.com",
    "facebook.com",
    "negocio.site",
    "wordpress.com",
    "blogspot.com",
]

def classificar(empresa):
    site = empresa["site"].strip().lower()
    if not site:
        return "SEM_SITE"
    for plataforma in PLATAFORMAS:
        if plataforma in site:
            return "SITE_TERCEIRO" 
    return "SITE_PROPRIO"

if __name__ == "__main__":
    print(verificar_site("https://www.google.com"))
    print(verificar_site("https://estenegocionaoexiste123456.com.br"))
    print(verificar_site(""))