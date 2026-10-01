CREATE TABLE time (
id INTEGER PRIMARY KEY,
nome VARCHAR(50)
);
CREATE TABLE partida (
id INTEGER PRIMARY KEY,
time_1 INTEGER,
time_2 INTEGER,
time_1_gols INTEGER,
time_2_gols INTEGER,
FOREIGN KEY(time_1) REFERENCES time(id),
FOREIGN KEY(time_2) REFERENCES time(id)
);
INSERT INTO time(id, nome) VALUES
(1,'CORINTHIANS'),
(2,'SÃO PAULO'),
(3,'CRUZEIRO'),
(4,'ATLETICO MINEIRO'),
(5,'PALMEIRAS');
INSERT INTO partida(id, time_1, time_2, time_1_gols, time_2_gols)
VALUES
(1,4,1,0,4),
(2,3,2,0,1),
(3,1,3,3,0),
(4,3,4,0,1),
(5,1,2,0,0),
(6,2,4,2,2),
(7,1,5,1,2),
(8,5,2,1,2);

CREATE VIEW vpartida AS
SELECT 
    p.id, 
    p.time_1, 
    t1.nome AS nome_time_1, 
    p.time_1_gols, 
    p.time_2_gols, 
    p.time_2, 
    t2.nome AS nome_time_2
FROM partida p
JOIN time t1 ON p.time_1 = t1.id
JOIN time t2 ON p.time_2 = t2.id
ORDER BY p.id ASC;

SELECT nome_time_1, nome_time_2, time_1_gols, time_2_gols 
FROM vpartida
WHERE nome_time_1 LIKE 'A%' OR nome_time_1 LIKE 'C%'
   OR nome_time_2 LIKE 'A%' OR nome_time_2 LIKE 'C%'
ORDER BY nome_time_1 ASC, nome_time_2 ASC;

create view vpartida_classificacao AS
select id as id_partida, nome_time_1, nome_time_2,
    case 
        when time_1_gols > time_2_gols then nome_time_1
        when time_1_gols < time_2_gols then nome_time_2
        else 'EMPATE'
    END AS classificacao_vencedor
FROM vpartida
ORDER BY classificacao_vencedor DESC;

select * from vpartida_classificacao;

create or replace view vtime as
select t.id, t.nome
-- Partidas
(select count(time_1) from partida where time_1 = t.id) + (select count(time_2) from partida where time_2 = t.id) as partidas
-- Vitorias
(select sum(case when time_2_gols > time_1_gols then 1 else 0 end) from partida where time_2 = t.id) +
(select sum(case when time_1_gols > time_2_gols then 1 else 0 end) from partida where time_1 = t.id)
-- Empates
(select sum(case when time_2_gols = time_1_gols then 1 else 0 end) from partida where time_2 = t.id) +
(select sum(case when time_1_gols = time_2_gols then 1 else 0 end) from partida where time_1 = t.id)
-- Derrota
(select sum(case when time_2_gols < time_1_gols then 1 else 0 end) from partida where time_2 = t.id) +
(select sum(case when time_1_gols < time_2_gols then 1 else 0 end) from partida where time_1 = t.id)
-- Pontos
(select sum(case when time_2_gols > time_1_gols then 3 when time_2_gols = time_1_gols then 1 else 0 end)
from partida where time_2 = t.id) + 
(select sum(case when time_2_gols < time_1_gols then 3 when time_2_gols = time_1_gols then 1 else 0 end)
from partida where time_1 = t.id) as pontos
from time t
order by pontos desc;

DROP VIEW vpartida;
