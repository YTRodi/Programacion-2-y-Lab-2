---------------------- Query 01 --------------------
SELECT * FROM Alumnos

---------------------- Query 02 --------------------
--SELECT A.nombre FROM Alumnos AS A

---------------------- Query 03 --------------------
--SELECT P.nombre
--FROM Profesores AS P
--WHERE nombre LIKE '%a%'

---------------------- Query 04 --------------------
--SELECT P.apellido
--FROM Profesores AS P
--WHERE P.apellido LIKE 'd%'

---------------------- Query 05 --------------------
--SELECT *
--FROM Alumnos AS A
--WHERE A.legajo = 1642070223999

---------------------- Query 06 --------------------
----Veo el alumno con ese legajo.
--SELECT A.nombre, A.apellido
--FROM Alumnos AS A
--WHERE A.legajo = 1642070223999

----Seteo el nombre y apellido
--UPDATE Alumnos 
--SET nombre = 'Yago',
--	apellido = 'Rodi'
--WHERE Alumnos.legajo = 1642070223999

---------------------- Query 07 --------------------
----Veo el alumno con ese legajo.
--SELECT A.nombre, A.apellido
--FROM Alumnos AS A
--WHERE A.legajo = 1642070223999

----Elimino el alumno con ese legajo.
--DELETE FROM Alumnos WHERE Alumnos.legajo = 1642070223999

---------------------- Query 08 --------------------
--SELECT A.nombre + ' ' + A.apellido AS 'Nombre y Apellido' ,
--	   Cursos.nombre
--FROM Alumnos AS A
--INNER JOIN Cursos ON A.curso = Cursos.id --Conecto tablas
--WHERE A.curso = 1 --1 = 2ºC-1


---------------------- Query 09 --------------------
--SELECT A.nombre + ' ' + A.apellido AS 'Nombre y Apellido' ,
--	   C.nombre AS 'Curso',
--	   P.nombre AS 'Nombre profesor'--,
--	   --P.legajo AS 'Legajo profesor'
--FROM Alumnos AS A
--INNER JOIN Cursos AS C ON A.curso = C.id --Conecto tablas
--INNER JOIN Profesores AS P ON C.profesor = P.legajo
--WHERE A.curso = 1
