// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");







//Console.WriteLine(NombreAlumno);
//Console.WriteLine(NumeroCuenta);
//Console.WriteLine(Email);
//Console.WriteLine(NombreAsignatura);
//Console.WriteLine(Horario);
//Console.WriteLine(NombreDocente);
//Console.WriteLine(N1);
//Console.WriteLine(N2);
//Console.WriteLine(N3);





Asignatura asignatura1 = new Asignatura();



Console.WriteLine("Ingrese Nombre del Alumno");
asignatura1.NombreAlumno = Console.ReadLine();
Console.WriteLine("Ingrese Numero de cuenta");
asignatura1.NumeroCuenta = Console.ReadLine();
Console.WriteLine("Ingrese Email");
asignatura1.Email = Console.ReadLine();
Console.WriteLine("Ingrese Nombre de la Asignatura");
asignatura1.NombreAsignatura = Console.ReadLine();
Console.WriteLine("Ingrese Horario");
asignatura1.Horario = Console.ReadLine();
Console.WriteLine("Ingrese Nombre del Docente");
asignatura1.NombreDocente = Console.ReadLine();
Console.WriteLine("Ingrese Nota primer parcial: ");
asignatura1.N1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ingrese Nota Segundo parcial: ");
asignatura1.N2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ingrese Nota Tercer Parcial: ");
asignatura1.N3 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"resultado {asignatura1.CalcularNotaFinal()}");



Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Impresion");


asignatura1.Imprimir();






//asignatura1.N1 = Console.ReadLine();
//asignatura1.N2 = Console.ReadLine();
//asignatura1.N3 = Console.ReadLine();

//asignatura1.CalcularNotaFinal();


//Console.WriteLine(asignatura1.CalcularNotaFinal);




