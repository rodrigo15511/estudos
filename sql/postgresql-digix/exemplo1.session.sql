create table exemplo.aluno(
    idt_aluno integer not null primary key,
    des_nome varchar(255),
    num_grau integer
);
create table exemplo.amigo(
    idt_aluno1 integer not null ,
    idt_aluno2 integer not null ,
    CONSTRAINT pk_amigo PRIMARY KEY (idt_aluno1, idt_aluno2),  
    CONSTRAINT fk_amigo_aluno1 FOREIGN KEY (idt_aluno1) REFERENCES aluno(idt_aluno),
    CONSTRAINT fk_amigo_aluno2 FOREIGN KEY (idt_aluno2) REFERENCES aluno(idt_aluno) 

);
create table exemplo.curtida(
    idt_aluno1 integer not null ,
    idt_aluno2 integer not null ,
    CONSTRAINT pk_curtida PRIMARY KEY (idt_aluno1, idt_aluno2),  
    CONSTRAINT fk_curtida_aluno1 FOREIGN KEY (idt_aluno1) REFERENCES aluno(idt_aluno),
    CONSTRAINT fk_curtida_aluno2 FOREIGN KEY (idt_aluno2) REFERENCES aluno(idt_aluno)
)
