create table usuario(
	id int,
	nome varchar(50),
	email varchar(50),
	primary key(id)
);
create table cargo (
	id int primary key not null,
	nome varchar(50),
	fk_usuario int,
	constraint fk_cargo_usuario foreign key(fk_usuario)
	references usuario(id)
);
insert into usuario values (1, 'Joao', 'Joao@gmail.com');
insert into usuario values (2, 'Maria', 'Maria@gmail.com');
insert into usuario values (3, 'Ciclano', 'Ciclano@gmail.com');

alter table cargo add column salario decimal(10,2);
insert into cargo values (1, 'Analista de Sistemas', 1, 61000.00);
insert into cargo values (2, 'Analista de Banco de Dados', 1, 6000.00);
insert into cargo values (3, 'Analista de Redes', 1, 66000.00);

-- Alterar os dados
update cargo set salario = 6500.00 where id = 2;
update usuario set nome = 'Rodrigo' where id = 1;

-- Deletar
delete from usuario where id = 3;
-- Consultar
select * from usuario;
select * from cargo;

select * from usuario left join cargo on usuario.id = cargo.fk_usuario;

select * from usuario right join cargo on usuario.id = cargo.fk_usuario;

-- Imprimir somente o nome da tabela Cargo
select cargo .nome from cargo;
select c.nome from cargo;

--Abreviação de tabela
selct asd.nome from cargo asd;
select c.nome, u.nome from cargo c, usuario u;
--Aplicacao de condiçoes
select c.nome from cargo c where id = 1; -- vai imprimir o nome do cargo
select c.id from usuario u where u.nome = 'Joao';

select u.nome from usuario u where u.id = 2; -- operador ou que imprimir id 1 ou 2 
select u.nome from usuario u where u.id = 2;

--selecionar um lista id
select u.nome from usuario u where id in (1,2,3);
select u.nome from usuario u where id not in (1,2,3);

-- utilizar o operador Between para ser usados o que esta entre os intervalos
select u.nome from usuario u where id between 1 and 3;

-- Utilizar o operador like
select u.nome from usuario u where u.nome like 'Ma%';

--operadores de comparação
select u.id, u.nome from usuario u where u.id > 1;
select u.id, u.nome from usuario u where u.id >= 1;

--operadores ordenacao
select u.id, u.nome from usuario u order by id desc;
select u.id, u.nome from usuario u order by id asc;

--limitar os resultados
select * from usuario limit 1;

--agrupamento
select c.nome, u.id from usuario u, cargo cargo
where u.cargo = c.fk_usuario group by c.nome; -- group by = agrupado por nome
-- operador count e pra contar qnts vezes apareceu na coluna