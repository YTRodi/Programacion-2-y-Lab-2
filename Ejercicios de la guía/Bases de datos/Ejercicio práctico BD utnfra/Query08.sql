SELECT A.nombre + ' ' + A.apellido AS 'Nombre y Apellido' ,
	   Cursos.nombre
FROM Alumnos AS A
INNER JOIN Cursos ON A.curso = Cursos.id --Conecto tablas
WHERE A.curso = 1 --1 = 2ºC-1
