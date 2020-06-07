-- EJERCICIO 62

INSERT INTO Llamadas (Duracion,Origen,Destino,Costo,Tipo) 
VALUES
(
	150,
	'1136153288',
	'42121743',
	67,
	0 --LOCAL
)

INSERT INTO Llamadas (Duracion,Origen,Destino,Costo,Tipo) 
VALUES
(
	120,
	'42711644',
	'12345678',
	'118.8',
	1 --PROVINCIAL
)


SELECT * FROM Llamadas

DELETE FROM Llamadas WHERE id = 19

UPDATE Llamadas SET LLamadas.Costo  = 15 WHERE id = 3