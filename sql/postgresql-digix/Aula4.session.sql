create table funcao(
    idFuncao SERIAL PRIMARY KEY,
    nome VARCHAR(45) NOT NULL  
);
create table funcionario(
    idFuncionario SERIAL PRIMARY KEY,
    nome VARCHAR(45) NOT NULL,
    carteiraTrabalho INT NOT NULL,
    dataContratacao DATE NOT NULL,
    salario FLOAT NOT NULL
);

CREATE TABLE horario_trabalho_funcionario (
    horario_idhorario INT,
    funcionario_idFuncionario INT,
    funcao_idFuncao INT,
    PRIMARY KEY (horario_idhorario, funcionario_idFuncionario), 
    FOREIGN KEY (horario_idhorario) REFERENCES horario(idhorario), 
    FOREIGN KEY (funcionario_idFuncionario) REFERENCES funcionario(idFuncionario),
    FOREIGN KEY (funcao_idFuncao) REFERENCES funcao(idFuncao)
);

create table horario (
    idhorario SERIAL PRIMARY KEY,
    horario TIME NOT NULL
);

create table sala (
    idSala SERIAL PRIMARY KEY,
    nome VARCHAR(45) NOT NULL,
    capacidade INT NOT NULL
);

create table filme (
    idFilme SERIAL PRIMARY KEY,
    nomeBR VARCHAR(45) NOT NULL,
    nomeEN VARCHAR(45) NOT NULL,
    anoLancamento INT NOT NULL,
    diretor_idDiretor INT,
    genero_idGenero INT,
    sinopse TEXT,
    FOREIGN KEY (diretor_idDiretor) REFERENCES diretor(idDiretor),
    FOREIGN KEY (genero_idGenero) REFERENCES genero(idGenero)
);

create table diretor (
    idDiretor SERIAL PRIMARY KEY,
    nome VARCHAR(45) NOT NULL
);

create table genero (
    idgenero SERIAL PRIMARY KEY,
    nome VARCHAR(45) NOT null
);

CREATE TABLE filme_exibido_sala (
    filme_idFilme INT,
    sala_idSala INT,
    horario_idHorario INT,
    PRIMARY KEY (filme_idFilme, sala_idSala, horario_idHorario),
    FOREIGN KEY (filme_idFilme) REFERENCES filme(idFilme),
    FOREIGN KEY (sala_idSala) REFERENCES sala(idSala),
    FOREIGN KEY (horario_idHorario) REFERENCES horario(idHorario)
);

CREATE TABLE premiacao (
    idPremiacao SERIAL PRIMARY KEY,
    nome VARCHAR(45) NOT NULL,
    ano INT NOT NULL
);

CREATE TABLE filme_has_premiacao (
    filme_idFilme INT,
    premiacao_idPremiacao INT,
    ganhou BOOLEAN,
    PRIMARY KEY (filme_idFilme, premiacao_idPremiacao),
    FOREIGN KEY (filme_idFilme) REFERENCES filme(idFilme),
    FOREIGN KEY (premiacao_idPremiacao) REFERENCES premiacao(idPremiacao)
);

INSERT INTO funcao (nome) VALUES 
('Atendente'), 
('Gerente'), 
('Bilheteiro'), 
('Projecionista'), 
('Zelador');

INSERT INTO funcionario (nome, carteiraTrabalho, dataContratacao, salario) VALUES 
('Carlos Silva', 123456, '2020-05-10', 2500.00),
('Ana Souza', 789012, '2019-03-22', 3000.00),
('João Pereira', 345678, '2021-07-15', 2200.00),
('Mariana Costa', 901234, '2018-09-30', 4000.00),
('Pedro Mendes', 567890, '2022-01-10', 2800.00);

INSERT INTO horario (horario) VALUES 
('10:00:00'), 
('12:00:00'), 
('15:00:00'), 
('18:00:00'), 
('21:00:00');

INSERT INTO sala (nome, capacidade) VALUES 
('Sala 1', 100), 
('Sala 2', 80), 
('Sala 3', 120), 
('Sala 4', 150), 
('Sala 5', 90);

INSERT INTO genero (nome) VALUES 
('Ação'), 
('Drama'), 
('Comédia'), 
('Ficção Científica'), 
('Terror');

INSERT INTO diretor (nome) VALUES 
('Steven Spielberg'),
('Christopher Nolan'),
('Quentin Tarantino'),
('Martin Scorsese'),
('Ridley Scott');

INSERT INTO filme (nomeBR, nomeEN, anoLancamento, diretor_idDiretor, genero_idGenero, sinopse) VALUES 
('Jurassic Park', 'Jurassic Park', 1993, 1, 11, 'Dinossauros atacam um parque temático.'), 
('A Origem', 'Inception', 2010, 2, 12, 'Sonhos dentro de sonhos em um filme intrigante.'), 
('Pulp Fiction', 'Pulp Fiction', 1994, 3, 13, 'Histórias entrelaçadas de criminosos.'),   
('O Lobo de Wall Street', 'The Wolf of Wall Street', 2013, 4, 12, 'A história de um corretor da bolsa ambicioso.'), 
('Alien', 'Alien', 1979, 5, 15, 'Um alienígena mortal invade uma nave espacial.');


INSERT INTO filme_exibido_sala (filme_idFilme, sala_idSala, horario_idHorario) VALUES 
(1, 1, 1), 
(1, 2, 2), 
(2, 3, 3), 
(3, 4, 4), 
(4, 5, 5);

SELECT AVG(salario) AS media_salarial FROM funcionario;

SELECT f.nome AS nome_funcionario, fn.nome AS nome_funcao
FROM funcionario f
LEFT JOIN horario_trabalho_funcionario htf ON f.idFuncionario = htf.funcionario_idFuncionario
LEFT JOIN funcao fn ON htf.funcao_idFuncao = fn.idFuncao;

SELECT f1.nome AS nome_funcionario
FROM funcionario f1
JOIN horario_trabalho_funcionario htf1 ON f1.idFuncionario = htf1.funcionario_idFuncionario
JOIN horario_trabalho_funcionario htf2 ON htf1.horario_idhorario = htf2.horario_idhorario
JOIN funcionario f2 ON htf2.funcionario_idFuncionario = f2.idFuncionario
WHERE f1.idFuncionario <> f2.idFuncionario;

SELECT f.nomeBR AS nome_filme
FROM filme f
JOIN filme_exibido_sala fes ON f.idFilme = fes.filme_idFilme
GROUP BY f.nomeBR
HAVING COUNT(DISTINCT fes.sala_idSala) >= 2;

SELECT DISTINCT f.nomeBR AS nome_filme, g.nome AS nome_genero
FROM filme f
JOIN genero g ON f.genero_idGenero = g.idgenero;

SELECT f.nomeBR AS nome_filme
FROM filme f
LEFT JOIN filme_has_premiacao fhp ON f.idFilme = fhp.filme_idFilme
WHERE fhp.premiacao_idPremiacao IS NULL;

SELECT d.nome AS nome_diretor
FROM diretor d
JOIN filme f ON d.idDiretor = f.diretor_idDiretor
GROUP BY d.nome
HAVING COUNT(*) >= 2;

SELECT f.nomeBR AS nome_filme
FROM filme f
JOIN filme_exibido_sala fes1 ON f.idFilme = fes1.filme_idFilme
JOIN filme_exibido_sala fes2 ON f.idFilme = fes2.filme_idFilme
WHERE fes1.sala_idSala = fes2.sala_idSala AND fes1.horario_idHorario <> fes2.horario_idHorario;

SELECT nome FROM diretor UNION SELECT nome FROM funcionario;

SELECT fn.nome AS nome_funcao, COUNT(*) AS quantidade_funcionarios
FROM funcionario f
JOIN horario_trabalho_funcionario htf ON f.idFuncionario = htf.funcionario_idFuncionario
JOIN funcao fn ON htf.funcao_idFuncao = fn.idFuncao
GROUP BY fn.nome;

SELECT f.nomeBR AS nome_filme
FROM filme f
JOIN filme_exibido_sala fes ON f.idFilme = fes.filme_idFilme
JOIN sala s ON fes.sala_idSala = s.idSala
WHERE s.capacidade > (SELECT AVG(capacidade) FROM sala);

select f.nomeBR, s.nome as sala, s.capacidade
from filme_exibido_sala fs
join sala s on f.sala_idSala = s.idSalas
join filme f on fs.filme_idFilme = f.idFilme
where s.capacidade > (select avg (capacidade) from sala);











