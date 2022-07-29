/*Insertando datos en las tablas correspondientes */
USE SchoolDatabase
GO

-- Insertar 2 estudiantes en la tabla 'Students'
INSERT INTO Students
   ([Name], [Birthday], [Height], [Weight])
VALUES
   (N'Alessandra', '2-7-1995', 1.75, 60),
   (N'Christian', '9-12-1996', 1.78, 66)
GO

SELECT * FROM Students
GO

-- Insertar 3 cursos en la tabla 'Courses'
INSERT INTO Courses
   ([Name])
VALUES
   (N'Modelado 3D'),
   (N'Programación Orientada a Objetos'),
   (N'Artes Escenicas')
GO

SELECT * FROM Courses
GO

-- Insertar 4 registros en CourseStudent para relacionar Courses y Students 
INSERT INTO CourseStudent
   ([CoursesId], [StudentsId])
VALUES
   (1, 1),
   (1, 2),
   (3, 1),
   (2, 2)
GO

SELECT * FROM CourseStudent
GO