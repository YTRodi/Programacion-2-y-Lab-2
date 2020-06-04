--SELECT nombre, edad --seleccionar todo de mascotas
--FROM Mascotas 
--WHERE edad >= 4 AND nombre = 'Falatel'
--WHERE edad >= 4 AND nombre LIKE 'F%' -- que empiece con F y siga con cualquier cosa
--WHERE nombre LIKE 'S%'
--WHERE nombre LIKE 'F_l%' --F, que tenga UN carácter en ESA posición,
--WHERE nombre LIKE '%al%'
--WHERE nombre IN ('Aldo','Falafel','Silvestre','Mal%') --NO TRAE MALO

--------------------------------------------------------------------------------

--SELECT nombre, edad, idVeterinario
--FROM Mascotas
--WHERE edad BETWEEN 3 AND 7
--ORDER BY nombre  DESC, nombre

--SELECT nombre, edad, idVeterinario
--FROM Mascotas
--WHERE edad BETWEEN 3 AND 7
--ORDER BY nombre  DESC, nombre

		 ---------- MEZCLAR DOS TABLAS ----------

--SELECT Mascotas.nombre, Mascotas.edad, Mascotas.duenio,
-- Veterinarios.nombre, Veterinarios.apellido
--FROM Mascotas INNER JOIN Veterinarios
-- ON Mascotas.idVeterinario = Veterinarios.id

--SELECT Mascotas.nombre, Mascotas.edad, Mascotas.duenio,
-- Veterinarios.nombre + ' ' + Veterinarios.apellido AS 'Veterinario'
--FROM Mascotas INNER JOIN Veterinarios
-- ON Mascotas.idVeterinario = Veterinarios.id

--SELECT M.nombre, M.edad,
-- V.nombre + ' ' + V.apellido AS 'Veterinario',
-- D.nombre, D.direccion

--FROM Mascotas AS M INNER JOIN Veterinarios AS V
--  ON M.idVeterinario = V.id 

-- --LEFT JOIN Duenios AS D ON M.idDuenio = D.dni
-- LEFT JOIN Duenios AS D ON M.idDuenio = D.dni

--------------------------------------------------------------------------------

				---------- INSERT ----------
--INSERT INTO Mascotas (nombre, edad, idVeterinario, idDuenio) --Si no pongo los campos, los toma tal cuál están en al tabla
--VALUES ('Pelusa', 5, 1, 1), ('Pelusa', 5, 1, 1)

--INSERT INTO Mascotas (nombre, edad, idVeterinario, idDuenio)--PARA COPIAR UNA BASE DE DATOS
--SELECT nombre, edad, idVeterinario, idDuenio FROM Mascotas
----SI LE SACO UN CAMPO Y NO LO LLENO (FIJARSE SI ES NULLEABLE O NO...)

				---------- DELETE ----------
DELETE FROM Mascotas WHERE id > 9 --SIEMPRE el WHERE!!!!!!

--HACE LO MISMO QUE EL DELETE, PERO SI CARGO UN DATO EMPIEZA DEL ID 1
TRUNCATE TABLE Mascotas 

				---------- UPDATE ----------
UPDATE Mascotas SET nombre = 'Tomy' WHERE id = 8 --SIEMPRE el WHERE!!!!!!

--------------------------------------------------------------------------------

--SELECT AVG(edad)
--FROM Mascotas

--COMETARIOS
-- IN = le pasamos una lista de strings