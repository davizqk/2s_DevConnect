--DQL
USE db_devconnect_;

--Lista todos os usuario em ordem crescente
SELECT id, nome_completo
FROM tb_usuario;

--Lista todos os usuario em ordem decrescente
SELECT id, nome_completo
FROM tb_usuario
ORDER BY id DESC;

--Mostre quantos usuarios existe na base
SELECT COUNT(nome_completo) AS qtd_usuarios FROM tb_usuario;

--Exiba todos os nomes dos seguidores (de quem esta seguindo e de quem sera seguido)
SELECT
	U1.nome_usuario,
	U2.nome_usuario
FROM tb_seguidor S
INNER JOIN tb_usuario U1 ON S.id_usuario_seguir  = U1.id_usuario_seguir
INNER JOIN tb_usuario U2 ON S.id_usuario_seguido = U2.id_usuario_seguido

--Exiba quantos seguidores possui um respectivo usuario

--Exiba todas as publicacoes contendo a descricao, o caminho da imagem e o nome de usuario
SELECT
	P.descricao AS 'Descrição',
	P.imagem_url AS 'Imagem',
	U.nome_usuario AS 'Usuario'
FROM tb_publicacao P
INNER JOIN tb_usuario U ON P.id_usuario = U.id_usuario;

--Exiba todos os comentarios com o nome e o texto de uma respectiva publicacao
SELECT
	U.nome_usuario AS 'Usuario',
	C.texto AS 'Comentario'
FROM tb_comentario C
INNER JOIN tb_usuario U ON C.id_usuario = U.id_usuario;

--Exiba a quantidade de curtidas de uma respectiva publicacao

--Exiba todos os usuarios que nao chegaram a fazer publicacoes
SELECT 
	U.nome_usuario AS 'Usuario', 
	data_publicacao AS 'Data da Publicação'
FROM tb_usuario U
LEFT JOIN tb_publicacao P ON U.id_usuario = P.id_usuario
WHERE P.id_publicacao IS NULL;

--Exiba todos os usuarios que nao chegaram a fazer reacoes
SELECT 
	U.nome_usuario AS 'Usuario', 
	data_comentario 'Data do Comentario'
FROM tb_usuario U
LEFT JOIN tb_comentario C ON U.id_usuario = C.id_usuario
WHERE C.id_comentario IS NULL;


--VIEW
CREATE VIEW vw_usuario_publicacoes AS
SELECT
    U.nome_usuario,
    P.descricao,
    P.imagem_url,
    P.data_publicacao
FROM
    tb_usuario U
JOIN
    tb_publicacao P ON U.id_usuario = P.id_usuario;

	SELECT * FROM vw_usuario_publicacoes