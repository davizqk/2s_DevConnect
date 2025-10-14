--DML
USE db_devconnect_;

--INSERIR UM REGISTRO NA TABELA USUARIO
INSERT INTO tb_usuario (nome_completo, nome_usuario, email, senha, foto_perfil_url)
VALUES	('Davi Muniz Duarte', 'davizqk', 'davi1234@gmail.com', 'senai@134', 'ht//www.noti/Processo-Seletivo-280');

INSERT INTO tb_usuario (nome_completo, nome_usuario, email, senha, foto_perfil_url)
VALUES	('Walyson Menezes', 'waly25', 'waly13@yahoo.com.br', 'waly123', 'ht//wwwivo-280.noti/Processo-Selet');

INSERT INTO tb_usuario (nome_completo, nome_usuario, email, senha, foto_perfil_url)
VALUES	('Paulo Andre', 'paulo325', 'paulo3@yahoo.com.br', 'paulo23', 'ht//wwwivoocesso-S-280.noti/Prelet'),
		('Gustavo Augusto', 'G.A425', 'G.A77@gmail.com', 'G.A777', 'ht//wwrocesso-Selewotiivo-280.n/Pt');

INSERT INTO tb_usuario (nome_completo, nome_usuario, email, senha, foto_perfil_url)
VALUES	('Gabriel Figueira', 'fifi22', 'complexo43@yahoo.com.br', 'gabriel23', 'ht//wwwivoocesso-S-280.noti/Prelet'),
		('Marcos Piaui', 'piaui333', 'marcospiaui@yahoo.com.br', 'marcos23', 'ht//wwwivoocesso-S-280.noti/Prelet'),
		('Matheus Felix', 'felix_bandido', 'felixTTI@gmail.com.br', 'TTI23', 'ht//wwwivoocesso-S-280.noti/Prelet'),
		('Francisco Hugo', 'hugoBig', 'hugoBIG@yahoo.com.br', 'Bigao23', 'ht//wwwivoocesso-S-280.noti/Prelet'),
		('Gustavo negueba', 'gueba85', 'guebadomal@yahoo.com.br', 'guebapi2', 'ht//wwwivoocesso-S-280.noti/Prelet'),
		('Joao Vitor', 'jvPeri3', 'jvperigoso@gmail.com', 'jvzao3', 'ht//wwwivoocesso-S-280.noti/Prelet'),
		('Nathan Policarpo', 'nathi157', 'nathandoroubo@gmail.com', 'paulo23', 'ht//wwwivoocesso-S-280.noti/Prelet');

INSERT INTO tb_usuario (nome_completo, nome_usuario, email, senha, foto_perfil_url)
VALUES	('Lorenzo Casca', 'lolococa', 'coca55@yahoo.com.br', 'lorenzo23', 'ht//wwwivoocesso-S-280.noti/Prelet');

SELECT * FROM tb_usuario;

--INSERIR UM REGISTRO NA TABELA PUBLICACAO
INSERT INTO tb_publicacao (id_usuario, descricao, imagem_url, data_publicacao)
VALUES	(2, 'passeio com a familia', 'ht//www.tivo-2noti/Processo-Sele80', '2025-10-01'),
		(1, 'passeio com os cria', 'ht//w2noti/Processww.tivo-o-Sele80', '2025-10-02');

SELECT * FROM tb_publicacao;

DELETE FROM tb_publicacao
WHERE descricao = 'passeio com a familia'

--INSERIR UM REGISTRO NA TABELA CURTIDA
INSERT INTO tb_curtida (id_usuario, id_publicacao)
VALUES	(2, 2);

SELECT * FROM tb_curtida;

TRUNCATE TABLE tb_comentario;

--INSERIR UM REGISTRO NA TABELA COMENTARIO
INSERT INTO tb_comentario (id_usuario, id_publicacao, texto, data_comentario)
VALUES	(2, 2, 'que lindo', '2025-10-01'),
		(3, 6, 'boa boa bb', '2025-10-02');
		
INSERT INTO tb_comentario (id_usuario, id_publicacao, texto, data_comentario)
VALUES	(1, 6, 'o mal ta na pista', '2025-10-02'),
		(11, 6, 'tropa do pisa', '2025-10-02'),
		(15, 6, 'rapaziada do mal', '2025-10-02'),
		(9, 2, 'que saudade da seca do piaui', '2025-10-02'),
		(13, 6, 'guebao do mal', '2025-10-02');


SELECT * FROM tb_comentario;

INSERT INTO tb_seguidor (id_usuario_seguir, id_usuario_seguido)
VALUES (1, 1);

SELECT * FROM tb_seguidor;
