CREATE TABLE Maquina (
 Id_Maquina INT PRIMARY KEY NOT NULL,
 Tipo VARCHAR(255),
 Velocidade INT,
 HardDisk INT,
 Placa_Rede INT,
 Memoria_Ram INT,
 Fk_Usuario INT,
 FOREIGN KEY(Fk_Usuario) REFERENCES Usuarios(ID_Usuario)
);
CREATE TABLE Usuarios (
 ID_Usuario INT PRIMARY KEY NOT NULL,
 Password VARCHAR(255),
 Nome_Usuario VARCHAR(255),
 Ramal INT,
 Especialidade VARCHAR(255)
);
CREATE TABLE Software (
 Id_Software INT PRIMARY KEY NOT NULL,
 Produto VARCHAR(255),
 HardDisk INT,
 Memoria_Ram INT,
 Fk_Maquina INT,
 FOREIGN KEY(Fk_Maquina) REFERENCES Maquina(Id_Maquina)
);
insert into Maquina values (1, 'Desktop', 2, 500, 1, 4, 1);
insert into Maquina values (2, 'Notebook', 1, 250, 1, 2, 2);
insert into Maquina values (3, 'Desktop', 3, 1000, 1, 8, 3);
insert into Maquina values (4, 'Notebook', 2, 500, 1, 4, 4);
insert into Usuarios values (1, '123', 'Joao', 123, 'TI');
insert into Usuarios values (2, '456', 'Maria', 456, 'RH');
insert into Usuarios values (3, '789', 'Jose', 789, 'Financeiro');
insert into Usuarios values (4, '101', 'Ana', 101, 'TI');
insert into Software values (1, 'Windows', 100, 2, 1);
insert into Software values (2, 'Linux', 50, 1, 2);
insert into Software values (3, 'Windows', 200, 4, 3);
insert into Software values (4, 'Linux', 100, 2, 4);


-- Criando Trigger de Restrição (postgresql)
create table Log_Exclusao_Maquina(
    Id_Log serial primary key,
    Id_Maquina
    Acao varchar(20),
    Data timestamp default current_timestamp
);

create or replace function log_exclusao_maquina()
returns trigger as $$
begin

    insert into Log_Exclusao_Maquina(Id_Maquina, Acao)
    values (old.Id_Maquina, 'Exclusao');

    return old;
end;
$$ language plpgsql;

create trigger Log_Exclusao_Maquina
after delete on Maquina
for each row
execute function log_exclusao_maquina();

--exe 2

CREATE FUNCTION impedir_senha_fraca()
RETURNS TRIGGER AS $$
BEGIN
    IF LENGTH(NEW.password) < 8 THEN
        RAISE EXCEPTION 'Senha fraca';
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

create trigger impedir_senha_fraca
before insert on Usuarios
for each row
execute function impedir_senha_fraca();

insert into usuarios values (5, '123', 'Joao', 123, 'TI');


--exe 3
create table Maquina_software_count(
    Id_Maquina INT,
    Count_software INT
);

CREATE OR REPLACE FUNCTION maquina_software_count()
RETURNS TRIGGER AS $$
BEGIN
    -- Insere ou atualiza a contagem de softwares para a máquina
    INSERT INTO Maquina_software_count (Id_Maquina, Count_software)
    VALUES (NEW.Fk_Maquina, (SELECT COUNT(*) FROM Software WHERE Fk_Maquina = NEW.Fk_Maquina))
    ON CONFLICT (Id_Maquina) -- Se já existe um registro com esse Id_Maquina
    DO UPDATE SET Count_software = EXCLUDED.Count_software; -- Atualiza a contagem

    RETURN NEW; -- Retorna NEW para triggers BEFORE ou AFTER INSERT
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER maquina_software_count
AFTER INSERT ON Software
FOR EACH ROW
EXECUTE FUNCTION maquina_software_count();

--exe 4
create or replace function impedir_remocao_ti()
returns trigger as $$
begin
    if old.Especialidade = 'TI' THEN
        raise exception 'Não pode ser removido';
    end if;
    return old;
end;
$$ language plpgsql;

create trigger impedir_remocao_ti
before delete on Usuarios
for each row
execute function impedir_remocao_ti();

--exe 5
create or replace function atualizar_memoria_ram()
returns trigger as $$
begin
    update  Maquina
    set Memoria_Total = (select sum(Memoria_Ram) from Software where Fk_Maquina = new.Id_Maquina)
    where Id_Maquina = new.Id_Maquina;
    return new;
end;
$$ language plpgsql;

create trigger atualizar_memoria_ram
after insert or delete on Software
for each row
execute function atualizar_memoria_ram();

--exe6
CREATE TABLE Especialidade_Log (
    Log_ID INT IDENTITY(1,1) PRIMARY KEY,
    ID_Usuario INT,
    Old_Especialidade VARCHAR(255),
    New_Especialidade VARCHAR(255),
    Data_Alteracao DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ID_Usuario) REFERENCES Usuarios(ID_Usuario)
);
    
CREATE TRIGGER TR_Usuarios_Insert_Especialidade
ON Usuarios
AFTER INSERT
AS
BEGIN
    INSERT INTO Especialidade_Log (ID_Usuario, New_Especialidade)
    SELECT ID_Usuario, Especialidade
    FROM inserted;
END;

--exe 7
CREATE TRIGGER TR_Software_Prevent_Essential_Delete
ON Software
INSTEAD OF DELETE
AS
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM deleted 
        WHERE Produto = 'Windows'
    )
    BEGIN
        RAISERROR ('Cannot delete Windows software. It is considered essential.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
    ELSE
    BEGIN
        DELETE FROM Software 
        WHERE Id_Software IN (SELECT Id_Software FROM deleted);
    END
END;

 
