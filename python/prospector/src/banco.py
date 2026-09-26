import sqlite3

def criar_tabela():
    conexao = sqlite3.connect("dados/empresas.db")
    cursor = conexao.cursor()
    cursor.execute("""
        CREATE TABLE IF NOT EXISTS empresas (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            nome TEXT,
            telefone TEXT,
            site TEXT,
            url TEXT,
            situacao TEXT,
            online INTEGER,
            status INTEGER
        )
    """)
    conexao.commit()
    conexao.close()

def salvar_empresas(empresas):
    conexao = sqlite3.connect("dados/empresas.db")
    cursor = conexao.cursor()
    for empresa in empresas:
        cursor.execute("SELECT id FROM empresas WHERE telefone = ?", (empresa["telefone"],))
        resultado = cursor.fetchone()

        if resultado:
            cursor.execute("""
                UPDATE empresas
                SET situacao = ?, online = ?, status = ?
                WHERE telefone = ?
            """, (
                empresa["situacao"],
                empresa["online"],
                empresa["status"],
                empresa["telefone"]
            ))
        else:
            cursor.execute("""
                INSERT INTO empresas (nome, telefone, site, url, situacao, online, status)
                VALUES (?, ?, ?, ?, ?, ?, ?)
            """, (
                empresa["nome"],
                empresa["telefone"],
                empresa["site"],
                empresa["url"],
                empresa["situacao"],
                empresa["online"],
                empresa["status"]
            ))

    conexao.commit()
    conexao.close()
    
def listar_do_banco():
    conexao = sqlite3.connect("dados/empresas.db")
    conexao.row_factory = sqlite3.Row
    cursor = conexao.cursor()
    cursor.execute("SELECT * FROM empresas")
    linhas = cursor.fetchall()
    conexao.close()

    empresas = []
    for linha in linhas:
        empresas.append(dict(linha))
    return empresas    

if __name__ == "__main__":
    empresas = listar_do_banco()
    for empresa in empresas:
        print(empresa)

