# Estudos

Tudo o que escrevi enquanto aprendia a programar: das primeiras páginas HTML às aulas de C#, ASP.NET e SQL do programa de Jovem Aprendiz na Digix, e aos projetos em Python e Java da FIAP. Está organizado por linguagem e, dentro de cada uma, mais ou menos na ordem em que aprendi.

A ideia deste repositório não é mostrar código perfeito. É mostrar a evolução.

## ⭐ Destaques

| Projeto | O que é |
|---|---|
| [**Jogo da Memória**](python/jogo-da-memoria) | Jogo no terminal com 4 fases (tabuleiros de 2x2 até 2x5), cartas embaralhadas numa matriz e validação de cada jogada |
| [**Prospector**](python/prospector) | Lê uma lista de empresas, verifica se elas têm site próprio e expõe os "leads" (quem não tem) numa API com FastAPI. Inclui o meu [diário de aprendizado](python/prospector/DIARIO.md) |
| [**Consumo de API em Java**](java/estudos-poo/consumirapi) | Consulta de endereço pela API do ViaCEP |
| [**Primeflix**](web/react/primeflix) | Catálogo de filmes em React consumindo a API do TMDB |
| [**Clone do Instagram**](web/html-css/instagram) | Tela de login e cadastro só com HTML e CSS |

## 🐍 Python

- **`fundamentos-1sem/`**: condicionais, laços, funções e listas (1º semestre da FIAP)
- **`exercicios-2sem/`**: matrizes, dicionários e sistemas pequenos de terminal (triagem, plantão, médias de notas)
- **`jogo-da-memoria/`**: o jogo descrito acima
- **`prospector/`**: o projeto descrito acima

## ☕ Java

- **`fundamentos-1sem/`**: classes, objetos e atributos de referência
- **`exercicios-2sem/`**: vetores, `ArrayList` e entidades (provas e treinos)
- **`estudos-poo/`**: orientação a objetos, herança, tratamento de exceções, conexão com banco Oracle via JDBC e consumo de API REST
- **`api-simpsons/`** 🚧: consumo da The Simpsons API com HttpClient e Gson (em andamento)

## #️⃣ C# e .NET (Digix)

- **`fundamentos/`**: primeiras aulas de C#: variáveis, condicionais, laços e matrizes
- **`aulas/`** e **`aulas-poo/`**: orientação a objetos: classes, herança, visibilidade, classes abstratas e tratamento de exceções
- **`acesso-a-dados/`** e **`acesso-a-dados-ado-dapper/`**: acesso a PostgreSQL com ADO.NET, Dapper e Entity Framework, incluindo aplicações Windows Forms (como o desafio da farmácia)
- **`aspnet/`**: APIs com ASP.NET Core e Entity Framework: endpoints, controllers, models e conexão com banco

## 🗄️ SQL

- **`postgresql-digix/`**: consultas, funções, procedures e triggers em PostgreSQL

## 🌐 Web

- **`html-css/`**: HTML semântico, formulários, box model, flexbox, um portfólio e um clone do Instagram
- **`javascript/`**: calculadora de IMC, gerador da Mega-Sena, temporizador, lista de tarefas, requisições HTTP e recursos do ES6 (spread, desestruturação, template strings, `find`/`filter`)
- **`react/`**: primeiros projetos em React: rotas, requisições, Firebase e o Primeflix
- **`typescript/`**: fundamentos de JavaScript e TypeScript: funções, operadores e orientação a objetos

## 🔧 C

Exercícios da disciplina de lógica de programação.

## 🌱 Git

- **`curso-git/`**: exercícios do curso de Git e GitHub (commits, `.gitignore`, README)

## Como rodar

- **Python:** `python arquivo.py`. O Prospector tem as instruções dele no próprio README.
- **Java:** abra a pasta do projeto no IntelliJ. O projeto `TratamentoExcessao` usa Maven e lê o usuário e a senha do banco das variáveis de ambiente `DB_USER` e `DB_PASSWORD`.
- **C#:** `dotnet run` dentro da pasta do projeto. Nos projetos com banco, troque `SUA_SENHA` na string de conexão pela senha do seu PostgreSQL local.
- **HTML/CSS/JS:** abra o `index.html` no navegador.
- **React:** `npm install` e `npm start` dentro da pasta. Os projetos com Firebase ou TMDB precisam de um arquivo `.env`; há um `.env.example` mostrando quais chaves preencher.
