--Veo el alumno con ese legajo.
SELECT A.nombre, A.apellido
FROM Alumnos AS A
WHERE A.legajo = 1642070223999

--Seteo el nombre y apellido
UPDATE Alumnos 
SET nombre = 'Yago',
	apellido = 'Rodi'
WHERE Alumnos.legajo = 1642070223999