--DQL
USE db_devconnect;

--Lista todos os usuario em ordem crescente
SELECT id, nome_completo
FROM tb_usuario;

--Lista todos os usuario em ordem decrescente
SELECT id, nome_completo
FROM tb_usuario
ORDER BY id DESC;

--Mostre quantos usuarios existe na base
SELECT COUNT(nome_completo) AS qtd_usuarios FROM tb_usuario;