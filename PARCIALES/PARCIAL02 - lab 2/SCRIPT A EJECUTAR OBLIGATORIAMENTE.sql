UPDATE Especialistas SET sexo = UPPER(LEFT(ClinicaUtn.dbo.Especialistas.sexo, 1)) +
LOWER(SUBSTRING(ClinicaUtn.dbo.Especialistas.sexo, 2, LEN(ClinicaUtn.dbo.Especialistas.sexo)))