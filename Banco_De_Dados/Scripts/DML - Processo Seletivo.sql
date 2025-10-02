--DML
USE db_devconnect;

--INSERIR UM REGISTRO NA TABELA USUARIO
INSERT INTO tb_usuario (nome_completo, nome_usuario, email, senha, foto_perfil_url)
VALUES	('Davi Muniz Duarte', 'davizqk', 'davi1234@gmail.com', 'senai@134', 'ht//www.noti/Processo-Seletivo-280');

INSERT INTO tb_usuario (nome_completo, nome_usuario, email, senha, foto_perfil_url)
VALUES	('Walyson Menezes', 'waly25', 'waly13@yahoo.com.br', 'waly123', 'ht//wwwivo-280.noti/Processo-Selet');

INSERT INTO tb_usuario (nome_completo, nome_usuario, email, senha, foto_perfil_url)
VALUES	('Paulo Andre', 'paulo325', 'paulo3@yahoo.com.br', 'paulo23', 'ht//wwwivoocesso-S-280.noti/Prelet'),
		('Gustavo Augusto', 'G.A425', 'G.A77@gmail.com', 'G.A777', 'ht//wwrocesso-Selewotiivo-280.n/Pt');

SELECT * FROM tb_usuario;

--INSERIR UM REGISTRO NA TABELA PUBLICACAO
INSERT INTO tb_publicacao (id_usuario, descricao, imagem_url, data_publicacao)
VALUES	(2, 'passeio com a familia', 'ht//www.tivo-2noti/Processo-Sele80', '2025-10-01');

SELECT * FROM tb_publicacao;

--INSERIR UM REGISTRO NA TABELA CURTIDA
INSERT INTO tb_curtida (id_usuario, id_publicacao)
VALUES	(2, 2);

SELECT * FROM tb_curtida;

--INSERIR UM REGISTRO NA TABELA COMENTARIO
INSERT INTO tb_comentario (id_usuario, id_publicacao, texto, data_comentario)
VALUES	(2, 2, 'que lindos', '2025-10-01');

SELECT * FROM tb_comentario;


