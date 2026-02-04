//Frandy Sena Taveras 2025-0945

using Tarea1_FrandySena.Classes;

var P1 = new Administrator(
    "Frandy",
    "Sena",
    19,
    "Dominicano",
    "402-xxxxxxxx",
    'M',
    "Administrator",
    "Santo Domingo Norte",
    "Director",
    "Administración",
    "Mi Empresa",
    60000,
    "Matemáticas",
    5,
    "Licenciado",
    "Nivel 1",
    "Área de Tecnología"
);

var P2 = new Teacher(
    "Ana",
    "Gomez",
    30,
    "Dominicana",
    "001-xxxxxxxx",
    'F',
    "Maestra",
    "Santo Domingo Este",
    "Profesora",
    "Matemáticas",
    "Mi Escuela",
    45000,
    "Matemáticas",
    10,
    "Magíster"
);

var P3 = new Student(
    "Luis",
    "Martinez",
    20,
    "Dominicano",
    "101-xxxxxxxx",
    'M',
    "Estudiante",
    "Santo Domingo Este",
    "Ingeniería de Sistemas",
    20210557,
    3.8,
    6
);

Console.WriteLine("Información del Administrador:");
Console.WriteLine($"Nombre: {P1.Name} {P1.LastName}");
Console.WriteLine($"Edad: {P1.Age}");
Console.WriteLine($"Nacionalidad: {P1.Nacionality}");
Console.WriteLine($"Cédula: {P1.IdCard}");
Console.WriteLine($"Género: {P1.Genre}");
Console.WriteLine($"Rol: {P1.Role}");
Console.WriteLine($"Dirección: {P1.Address}");
Console.WriteLine($"Titulo: {P1.JobTitle}");
Console.WriteLine($"Departamento: {P1.Department}");
Console.WriteLine($"Empresa: {P1.Company}");
Console.WriteLine($"Salario: {P1.Salary}");
Console.WriteLine($"Materia: {P1.Subject}");
Console.WriteLine($"Años de Experiencia: {P1.YearsOfExperience}");
Console.WriteLine($"Titulo: {P1.Title}");
Console.WriteLine($"Nivel: {P1.Level}");
Console.WriteLine($"Área: {P1.AreaOfOversight}");
Console.WriteLine();
