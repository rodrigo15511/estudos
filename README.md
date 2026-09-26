# Estudos

Tudo o que escrevi enquanto aprendia a programar, das primeiras páginas HTML aos projetos em Python e Java da FIAP. Está organizado por linguagem e, dentro de cada uma, mais ou menos na ordem em que aprendi.

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

## 🌐 Web

- **`html-css/`**: HTML semântico, formulários, box model, flexbox, um portfólio e um clone do Instagram
- **`javascript/`**: calculadora de IMC, gerador da Mega-Sena, temporizador, lista de tarefas, requisições HTTP e recursos do ES6 (spread, desestruturação, template strings, `find`/`filter`)
- **`react/`**: primeiros projetos em React: rotas, requisições, Firebase e o Primeflix

## 🔧 C

Exercícios da disciplina de lógica de programação.

## Como rodar

- **Python:** `python arquivo.py`. O Prospector tem as instruções dele no próprio README.
- **Java:** abra a pasta do projeto no IntelliJ. O projeto `TratamentoExcessao` usa Maven e lê o usuário e a senha do banco das variáveis de ambiente `DB_USER` e `DB_PASSWORD`.
- **HTML/CSS/JS:** abra o `index.html` no navegador.
- **React:** `npm install` e `npm start` dentro da pasta. Os projetos com Firebase ou TMDB precisam de um arquivo `.env`; há um `.env.example` mostrando quais chaves preencher.
