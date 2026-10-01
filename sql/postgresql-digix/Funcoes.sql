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

--Funcao
--Sao blocos de codigo que podem ser chamados para executar  uma tarefa especifica
-- aceitam parametro
-- podem ser definidas pelo o ususario ou podem chamada as funcoes embutidas
--3 tipos de funcoes- matematicas as datas e de string
--Funcoes matematicas
--exemplos
select abs(-10); -- retorna o valor absoluto
select round(10.5); -- ele redindao numero mais proximo possivel
select trunc (12.7); -- pega a parte interira
select power(2,3); -- eleva o primeiro numero ao segundo
select ln(4); -- retorna o logaritmo natural
select cos(30); -- retorna o cosseno do angelo radiano
select atan(0.5);
select asinh(0.5);-- retorna o arco seno hiperbolico
select sign(-50); -- retorna o sinal do numero

select concat('afasf', 'asf');--junta as 2 strings
select length('asfd'); -- comprimento
select lower('asfd'); -- deixa minusculo
select upper('asfd'); -- deixa maiusculo
select ltrim('ewqee');--excluir os espaços
select rtrim('ewqee');
select lpad('egadg', 10, '*');-- preenche o string com caracteres
select rpad('egadg', 10, '*');-- pra direita agr
select reverse('egadg');-- inverte o string

--funcoes da Data
select current_date; -- data atual
select extract(day from current_date);
select age ('2025-01-01' , '2020-02-02'); -- retorna a diferenca entre as datas
select interval '1 day';

--funcoes definidas pelo usuario
create function soma(a integer, b integer) returns integer as $$ --decalro, coloco parametros
begin --comeco da funcao
-- corpo da funcao
return a + b;
end;
$$ language plpgsql;

--chamar a funcao
select soma(10, 20);

--operacao de insert nas funcoes
create or replace function insere_partida (time_1, integer, time_2, time_1_gols integer, time_2_gols integer) returns void as $$


--funcao com variavel interna
create or replace function consulta_vencedor_por_time(is_time integer) returns varchar(50) as $$
declare
vencedor varchar(50);
begin
select case 
when sum(time_1_gols) > sum(time_2_gols) then (select nome from time where id = time_1)
when sum(time_1_gols) < sum(time_2_gols) then (select nome from time where id = time_2)
else 'Empate'
end into vencedor
from partidawhere time_1 = id_time or time_2 = id_time;
retun vencedor;
    end;
end;
$$ language plpgsql;



































































































