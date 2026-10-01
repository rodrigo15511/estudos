CREATE TABLE Pessoa (
    idPessoa SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cpf VARCHAR(11) UNIQUE NOT NULL
);

CREATE TABLE Engenheiro (
    crea INT PRIMARY KEY,
    idPessoa INT NOT NULL,
    FOREIGN KEY (idPessoa) REFERENCES Pessoa(idPessoa)
);

CREATE TABLE Edificacao (
    idEdificacao SERIAL PRIMARY KEY,
    metragemTotal DECIMAL(10,2) NOT NULL,
    endereco VARCHAR(200) NOT NULL,
    responsavel INT NOT NULL,
    FOREIGN KEY (responsavel) REFERENCES Engenheiro(crea)
);

CREATE TABLE UnidadeResidencial (
    idUnidade SERIAL PRIMARY KEY,
    metragemUnidade DECIMAL(10,2) NOT NULL,
    numQuartos INT NOT NULL,
    numBanheiros INT NOT NULL,
    proprietario INT NOT NULL,
    idEdificacao INT NOT NULL,
    FOREIGN KEY (proprietario) REFERENCES Pessoa(idPessoa),
    FOREIGN KEY (idEdificacao) REFERENCES Edificacao(idEdificacao)
);

CREATE TABLE Predio (
    idPredio SERIAL PRIMARY KEY,
    idEdificacao INT NOT NULL,
    nome VARCHAR(100) NOT NULL,
    numAndares INT NOT NULL,
    apPorAndar INT NOT NULL,
    FOREIGN KEY (idEdificacao) REFERENCES Edificacao(idEdificacao)
);

CREATE TABLE Casa (
    idCasa SERIAL PRIMARY KEY,
    idEdificacao INT NOT NULL,
    condominio BOOLEAN NOT NULL,
    FOREIGN KEY (idEdificacao) REFERENCES Edificacao(idEdificacao)
);

CREATE TABLE CasaSobrado (
    idCasaSobrado SERIAL PRIMARY KEY,
    idCasa INT NOT NULL,
    numAndares INT NOT NULL,
    FOREIGN KEY (idCasa) REFERENCES Casa(idCasa)
);

INSERT INTO Pessoa (nome, cpf) VALUES ('Carlos Silva', '98765432109');
INSERT INTO Engenheiro (crea, idPessoa) VALUES (12345, 1);
INSERT INTO Edificacao (metragemTotal, endereco, responsavel) VALUES (1200.75, 'Rua das Flores, 100', 12345);
INSERT INTO UnidadeResidencial (metragemUnidade, numQuartos, numBanheiros, proprietario, idEdificacao) VALUES (90.5, 4, 3, 1, 1);
INSERT INTO Predio (idEdificacao, nome, numAndares, apPorAndar) VALUES (1, 'Torre Alta', 15, 4);
INSERT INTO Casa (idEdificacao, condominio) VALUES (1, false);
INSERT INTO CasaSobrado (idCasa, numAndares) VALUES (1, 3);


select u.idUnidade, p.nome, e.endereco from unidaderesidencial u
join pessoa p on u.proprietario = p.idpessoa
join edificacao e on u.idedificacao = e.idedificacao;



