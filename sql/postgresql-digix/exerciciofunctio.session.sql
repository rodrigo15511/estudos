-- Criação das tabelas na ordem correta


create table Empregado (
    Nome varchar(50),
    Endereco varchar(500),
    CPF int primary key not null,
    DataNasc date,create table Departamento (
    NomeDep varchar(50),
    NumDep int primary key not null,
    CPFGer int,
    DataInicioGer date,
    foreign key (CPFGer) references Empregado(CPF)
);
    Sexo char(10),
    CartTrab int,
    Salario float,
    NumDep int,
    CPFSup int,
    foreign key (NumDep) references Departamento(NumDep),
    foreign key (CPFSup) references Empregado(CPF)
);

create table Projeto (
    NomeProj varchar(50),
    NumProj int primary key not null,
    Localizacao varchar(50),
    NumDep int,
    foreign key (NumDep) references Departamento(NumDep)
);

create table Dependente (
    idDependente int primary key not null,
    CPFE int,
    NomeDep varchar(50),
    Sexo char(10),
    Parentesco varchar(50),
    foreign key (CPFE) references Empregado(CPF)
);

create table Trabalha_Em (
    CPF int,
    NumProj int,
    HorasSemana int,
    foreign key (CPF) references Empregado(CPF),
    foreign key (NumProj) references Projeto(NumProj)
);

-- Inserção dos dados (mantida igual, pois estava correta)
insert into Departamento values ('Dep1', 1, null, '1990-01-01');
insert into Departamento values ('Dep2', 2, null, '1990-01-01');
insert into Departamento values ('Dep3', 3, null, '1990-01-01');
insert into Empregado values ('Joao', 'Rua 1', 123, '1990-01-01', 'M', 123, 1000, 1, null);
insert into Empregado values ('Maria', 'Rua 2', 456, '1990-01-01', 'F', 456, 2000, 2, null);
insert into Empregado values ('Jose', 'Rua 3', 789, '1990-01-01', 'M', 789, 3000, 3, null);
update Departamento set CPFGer = 123 where NumDep = 1;
update Departamento set CPFGer = 456 where NumDep = 2;
update Departamento set CPFGer = 789 where NumDep = 3;
insert into Projeto values ('Proj1', 1, 'Local1', 1);
insert into Projeto values ('Proj2', 2, 'Local2', 2);
insert into Projeto values ('Proj3', 3, 'Local3', 3);
insert into Dependente values (1, 123, 'Dep1', 'M', 'Filho');
insert into Dependente values (2, 456, 'Dep2', 'F', 'Filha');
insert into Dependente values (3, 789, 'Dep3', 'M', 'Filho');
insert into Trabalha_Em values (123, 1, 40);
insert into Trabalha_Em values (456, 2, 40);
insert into Trabalha_Em values (789, 3, 40);

CREATE OR REPLACE FUNCTION get_salario(cpf_empregado INT)
RETURNS FLOAT AS $$
BEGIN
    RETURN (SELECT Salario FROM Empregado WHERE CPF = cpf_empregado);
END;
$$ LANGUAGE plpgsql;

select get_salario(123);



CREATE OR REPLACE FUNCTION get_departamento_empregado(cpf_empregado INT)
RETURNS VARCHAR(50) AS $$
BEGIN
    RETURN (
        SELECT d.NomeDep 
        FROM Empregado e
        INNER JOIN Departamento d ON e.NumDep = d.NumDep
        WHERE e.CPF = cpf_empregado
    );
END;
$$ LANGUAGE plpgsql;

select get_departamento_empregado(123);

CREATE OR REPLACE FUNCTION get_gerente_departamento(num_dep INT)
RETURNS VARCHAR(50) AS $$
BEGIN
    RETURN (
        SELECT e.Nome 
        FROM Departamento d
        INNER JOIN Empregado e ON d.CPFGer = e.CPF
        WHERE d.NumDep = num_dep
    );
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION get_projetos_empregado(cpf_empregado INT)
RETURNS SETOF VARCHAR(50) AS $$
BEGIN
    RETURN QUERY (
        SELECT p.NomeProj 
        FROM Trabalha_Em t
        INNER JOIN Projeto p ON t.NumProj = p.NumProj
        WHERE t.CPF = cpf_empregado
    );
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION get_dependentes_empregado(cpf_empregado INT)
RETURNS SETOF VARCHAR(50) AS $$
BEGIN
    RETURN QUERY (
        SELECT NomeDep 
        FROM Dependente 
        WHERE CPFE = cpf_empregado
    );
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION get_gerente_empregado(cpf_empregado INT)
RETURNS VARCHAR(50) AS $$
BEGIN
    RETURN (
        SELECT e.Nome 
        FROM Empregado emp
        INNER JOIN Departamento d ON emp.NumDep = d.NumDep
        INNER JOIN Empregado e ON d.CPFGer = e.CPF
        WHERE emp.CPF = cpf_empregado
    );
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION get_total_horas(cpf_empregado INT)
RETURNS INT AS $$
BEGIN
    RETURN (
        SELECT SUM(HorasSemana) 
        FROM Trabalha_Em 
        WHERE CPF = cpf_empregado
    );
END;
$$ LANGUAGE plpgsql;