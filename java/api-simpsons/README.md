# API Simpsons 🚧 (em andamento)

Consulta personagens de Os Simpsons pela [The Simpsons API](https://thesimpsonsapi.com): o usuário digita o id de um personagem e o programa mostra nome, idade, ocupação, gênero e descrição.

## O que estou praticando

- Consumo de API REST com **Apache HttpClient**
- Conversão de JSON em objeto Java com **Gson**
- Separação em camadas: modelo (`api/Personagem`), serviço (`services/PersonagemService`) e execução (`main/TestePersonagem`)
- Tratamento de campos opcionais: `Integer` em vez de `int` para a idade, que pode vir `null`
- Gerenciamento de dependências com **Maven**

## Como rodar

Abra a pasta no IntelliJ e execute `TestePersonagem`. Uma janela pede o id do personagem (ex.: `1`).

Projeto de estudo, ainda em evolução.
