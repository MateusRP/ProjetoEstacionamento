create database if not exists estacionamento;
use Estacionamento;
create table if not exists tbl_gerente(
	ger_id int not null auto_increment,
    ger_nome varchar(100) not null,
    ger_usuario varchar(100) not null,
    ger_senha varchar(100) not null,
    primary key(ger_id)
);

insert into tbl_gerente(ger_nome,ger_usuario,ger_senha) values ("Mateus","chefe","1234");

create table if not exists tbl_funcionario(
	func_id int not null auto_increment,
    func_nome varchar(100) not null,
    func_cargo varchar (100) not null,
    func_usuario varchar(100) not null,
    func_senha varchar(100) not null,
    primary key (func_id)
);

create table if not exists tbl_veiculo(
	veic_id int not null auto_increment,
    veic_modelo varchar(100) not null,
    veic_cor varchar (50) not null,
    veic_placa varchar (10) not null,
    veic_hora_entrada DateTime not null,
    veic_hora_saida DateTime,
    primary key (veic_id)
);
