create table atividade(
    idAtividade SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL
);

create table instrutor(
    idinstrutor SERIAL PRIMARY KEY,
    rg INT NOT NULL,
    nome VARCHAR(45) NOT NULL,
    nascimento DATE NOT NULL,
    titulacao INT NOT NULL
);

CREATE TABLE turma (
    idturma SERIAL PRIMARY KEY,
    horario TIME NOT NULL,
    duracao INT NOT NULL,
    dataInicio DATE NOT NULL,
    dataFim DATE NOT NULL,
    atividade_idAtividade INT NOT NULL,
    instrutor_idinstrutor INT NOT NULL,
    FOREIGN KEY (atividade_idAtividade) REFERENCES atividade(idAtividade) ON DELETE CASCADE,
    FOREIGN KEY (instrutor_idinstrutor) REFERENCES instrutor(idinstrutor) ON DELETE CASCADE
);
CREATE TABLE telefone_instrutor (
    idtelefone SERIAL PRIMARY KEY,
    numero INT NOT NULL, 
    tipo VARCHAR(45) NOT NULL,
    instrutor_idinstrutor INT NOT NULL,
    FOREIGN KEY (instrutor_idinstrutor) REFERENCES instrutor(idinstrutor) ON DELETE CASCADE
);

create table aluno (
    codMatricula SERIAL PRIMARY KEY,
    turma_idturma INT NOT NULL,
    dataMatricula DATE,
    nome VARCHAR(45),
    endereco TEXT,
    telefone INT,
    dataNascimento DATE,
    altura FLOAT,
    peso INT
);

CREATE TABLE chamada (
    idchamada SERIAL PRIMARY KEY,
    data DATE NOT NULL,
    presente BOOLEAN NOT NULL,
    aluno_codMatricula INT NOT NULL,
    turma_idturma INT NOT NULL,
    FOREIGN KEY (aluno_codMatricula) REFERENCES aluno(codMatricula) ON DELETE CASCADE,
    FOREIGN KEY (turma_idturma) REFERENCES turma(idturma) ON DELETE CASCADE
);

INSERT INTO instrutor (RG, nome, nascimento, titulacao) VALUES
(12345678, 'Carlos Silva', '1980-05-10', 1),
(87654321, 'Mariana Souza', '1985-08-15', 2);

-- Inserir telefones dos instrutores
INSERT INTO telefone_instrutor (numero, tipo, instrutor_idinstrutor) VALUES
(11521, 'Celular', 1),
(16780, 'Residencial', 2);

-- Inserir atividades
INSERT INTO atividade (nome) VALUES
('Yoga'),
('Pilates'),
('Musculação');

-- Inserir turmas
INSERT INTO turma (horario, duracao, datainicio, datafim, atividade_idatividade, instrutor_idinstrutor) VALUES
('08:00:00', 60, '2025-02-01', '2025-06-01', 1, 1),
('10:00:00', 90, '2025-03-01', '2025-07-01', 2, 2);

-- Inserir alunos
INSERT INTO aluno (turma_idturma, dataMatricula, nome, endereco, telefone, dataNascimento, altura, peso) VALUES
(1, '20250205', 'João Pedro', 'Rua A, 123', 11999, '2000-01-15', 1.75, 70),
(2, '20250310', 'Ana Clara', 'Rua B, 456', 11888, '1998-06-20', 1.65, 60);

-- Inserir chamadas (presença)
INSERT INTO chamada (data, presente, aluno_codMatricula, turma_idturma) VALUES
('2025-02-06', TRUE, 1, 1),
('2025-03-11', FALSE, 2, 2);

select a.nome ,t.nome as turma from aluno a
inner join turma t on t.idturma = a.turma_idturma;

select t.nome, count(a.nome) as qntdaluno from turma t
inner join aluno a on turma_idturma = t.idturma
group by t.nome;

select avg(JUSTIFY_INTERVAL(atv6.aluno.dataNascimento - now())), atv6.turma.idturma from atv6.aluno join atv6.turma on atv6.turma.idTurma = atv6.aluno.turmaIdTurma
GROUP BY idTurma;

SELECT
    t.nome AS turma,
    ROUND(AVG(EXTRACT(YEAR FROM AGE(a.datanascimento)))::numeric, 2) AS media_idade
FROM aluno a
INNER JOIN turma t ON a.turma_idturma = t.idturma
GROUP BY t.nome;


SELECT
    t.nome AS turma,
    COUNT(a.codmatricula) AS total_alunos
FROM turma t
INNER JOIN aluno a ON t.idturma = a.turma_idturma
GROUP BY t.nome
HAVING COUNT(a.codmatricula) > 3;


--6
select a.nome as aluno, t.nome as turma
from aluno a
join chamada c on a.codmatricula = c.aluno_codmatricula
join turma t on c.turma_idturma = t.idturma
group by a.codMatricula, t.idturma
having count(c.presente) = 1;



SELECT
    i.nome AS instrutor,
    CASE
        WHEN t.idturma IS NULL THEN 'Sem turma'
        ELSE 'Possui turma'
    END AS status
FROM instrutor i
LEFT JOIN turma t ON i.idinstrutor = t.instrutor_idinstrutor;


SELECT DISTINCT
    i.nome AS instrutor,
    a.nome AS atividade
FROM instrutor i
INNER JOIN turma t ON i.idinstrutor = t.instrutor_idinstrutor
INNER JOIN atividade a ON t.atividade_idatividade = a.idatividade
WHERE a.nome IN ('Crossfit', 'Yoga');

SELECT
    a.nome AS aluno,
    COUNT(.turma_idturma) AS total_turmas
FROM aluno a
GROUP BY a.nome
HAVING COUNT(a.turma_idturma) > 1;


alter table turma add column nome VARCHAR(45);
update turma set nome = 'Yoga' where idturma = 1;
update turma set nome = 'Pilates' where idturma = 2;

select * from turma;
ALTER TABLE aluno a
ADD CONSTRAINT fk_aluno_turma 
FOREIGN KEY (turma_idturma) 
REFERENCES turma(idturma);

SELECT
    t.nome AS turma,
    COUNT(a.codmatricula) AS total_alunos
FROM turma t
LEFT JOIN aluno a ON t.idturma = a.turma_idturma
GROUP BY t.nome
ORDER BY total_alunos DESC
LIMIT 1;

SELECT
    a.nome AS aluno
FROM aluno a
WHERE a.codmatricula NOT IN (
    SELECT DISTINCT aluno_codmatricula
    FROM chamada
    WHERE presente = TRUE
);


