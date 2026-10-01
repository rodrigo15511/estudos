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