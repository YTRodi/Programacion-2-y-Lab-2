--Veo el alumno con ese legajo.
SELECT A.nombre, A.apellido
FROM Alumnos AS A
WHERE A.legajo = 1642070223999

--Elimino el alumno con ese legajo.
DELETE FROM Alumnos WHERE Alumnos.legajo = 1642070223999
