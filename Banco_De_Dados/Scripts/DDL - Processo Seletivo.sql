--DDL
CREATE DATABASE db_devconnect;

--comando usado para usar o BD
USE db_devconnect;

--Tabela usuario
CREATE TABLE tb_usuario (
	id				INT IDENTITY(1, 1)	PRIMARY KEY,
	nome_completo	NVARCHAR(255)		NOT NULL,
	nome_usuario	NVARCHAR(50)		UNIQUE	NOT NULL,
	email			NVARCHAR(255)		UNIQUE NOT NULL,
	senha			NVARCHAR(30)		NOT NULL,
	foto_perfil_url NVARCHAR(200)		NULL
);

SELECT * FROM tb_usuario;

--Tabela publicacao
CREATE TABLE tb_publicacao (
	id				INT IDENTITY(1, 1)	PRIMARY KEY,
	id_usuario		INT					NOT NULL FOREIGN KEY REFERENCES tb_usuario(id),
	descricao		NVARCHAR(300)		NULL,
	imagem_url		NVARCHAR(200)		NULL,
	data_publicacao	DATE				NOT NULL
);

SELECT * FROM tb_publicacao;

--Tabela curtida
CREATE TABLE tb_curtida (
	id INT IDENTITY(1, 1)	PRIMARY KEY,
	id_usuario INT			NOT NULL FOREIGN KEY REFERENCES tb_usuario(id),
	id_publicacao INT		NOT NULL FOREIGN KEY REFERENCES tb_publicacao(id),
);

SELECT * FROM tb_curtida;

--Tabela comentario
CREATE TABLE tb_comentario (
	id					INT IDENTITY (1, 1)	PRIMARY KEY,
	id_usuario			INT					NOT NULL FOREIGN KEY REFERENCES tb_usuario(id),
	id_publicacao		INT					NOT NULL FOREIGN KEY REFERENCES tb_publicacao(id),
	texto				NVARCHAR(300)		NULL,
	data_comentario		DATE				NOT NULL,
);

SELECT * FROM tb_comentario;

--Tabela intermediaria seguidor
CREATE TABLE tb_seguidor (
	id_usuario_seguir	INT NOT NULL,
	id_usuario_seguidor	INT NOT NULL,

	PRIMARY KEY (id_usuario_seguir, id_usuario_seguidor)
);

SELECT * FROM tb_seguidor;
