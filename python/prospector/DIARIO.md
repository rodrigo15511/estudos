## 21/07 - Fase 1 concluída
- Script lê CSV, classifica com/sem site, conta totais.
- Erros que me pegaram:
  - .strip sem parênteses = não executa, compara a função
  - vírgula no lugar do ponto = NameError estranho
  - empresa("nome") com parênteses = TypeError not callable
  - return dentro do with quebra: arquivo já fechou
- Comandos do dia a dia: cd, activate, python src/main.py
- Decisão: CSV em vez de banco, porque são 5 empresas.

## 22/07 - Fase 3 iniciada
- Refiz relatorio.py do zero, sem olhar o chat. Saiu.
- Instalei requests + requirements.txt
- requests NÃO completa https:// sozinho (navegador completa, biblioteca não)
- Decisão: normalizar URL na coleta, porque só ela sabe de onde o dado veio.
- Amanhã: escrever normalizar_url()

## 04/08 - API com filtro
- 3 endpoints: /, /empresas, /leads
- /leads filtra por != SITE_PROPRIO com append
- Entendi escopo: variável de função só existe dentro dela
- Aprendi: GET lê, POST cria; @app.get liga endereço à função
- Próximo: banco de dados SQLite
- Dívidas: código repetido nos 2 endpoints; renomear listar_leades

## 08/08 - Banco de dados no prospector
- Criei tabela SQLite (empresas.db)
- Implementei upsert: UPDATE se telefone já existe, senão INSERT
- Testei rodando banco.py 2x seguidas - continuou 5 empresas, não duplicou
- API migrada: /empresas e /leads agora leem do banco, não reprocessam
- Aprendi: ? como placeholder (evita SQL injection), WHERE em UPDATE, fetchone vs fetchall
- Pendente: README do projeto, endpoint /resumo, limpar código repetido
- Próximo passo do prospector: nenhum urgente, ferramenta está usável

## Decisão tomada
- Site de treino: pro consultório do meu irmão (dentista), não fictício
- Plano: domingos, 2h, começando pela estrutura HTML