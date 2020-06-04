SELECT A.nombre + ' ' + A.apellido AS 'Nombre y Apellido' ,
	   C.nombre AS 'Curso',
	   P.nombre AS 'Nombre profesor'--,
	   --P.legajo AS 'Legajo profesor'
FROM Alumnos AS A
INNER JOIN Cursos AS C ON A.curso = C.id --Conecto tablas
INNER JOIN Profesores AS P ON C.profesor = P.legajo
WHERE A.curso = 1