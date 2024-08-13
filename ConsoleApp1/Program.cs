
using ConsoleApp1;
using System;
using System.Reflection.Metadata.Ecma335;


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


    do
    {

    try
    {

        Console.WriteLine("Ingrese Nota primer parcial: ");
        asignatura1.N1 = Convert.ToInt16(Console.ReadLine());

        if (asignatura1.N1 > 30)
        {
            Console.WriteLine("El valor de la Primera nota no puede ser mayor al 30%, intente de nuevo");

        }
    }
    catch (Exception e) { 
    
        Console.WriteLine("Valor Invalido, Ingrese un numero de nota valido");
        asignatura1.N1 = 40;
    }

    } while (asignatura1.N1 > 30);


    do
    {
    try
    {
        Console.WriteLine("Ingrese Nota Segundo parcial: ");
        asignatura1.N2 = Convert.ToInt16(Console.ReadLine());

        if (asignatura1.N2 > 30)
        {
            Console.WriteLine("El valor de la Segunda nota no puede ser mayor al 30%, intente de nuevo");
        }

    } catch (Exception e)
    {
        Console.WriteLine("Valor Invalido, Ingrese un numero de nota valido");
        asignatura1.N2 = 40;
    }


    } while (asignatura1.N2 > 30);


    do
    {

    try
    {

        Console.WriteLine("Ingrese Nota Tercer Parcial: ");
        asignatura1.N3 = Convert.ToInt16(Console.ReadLine());


        if (asignatura1.N3 > 40)
        {
            Console.WriteLine("El valor de la Tercera nota no puede ser mayor al 40%, intente de nuevo");

        }

    } catch (Exception e)
    {
        Console.WriteLine("Valor Invalido, Ingrese un numero de nota valido");
        asignatura1.N3 = 41;
    }
    

    } while (asignatura1.N3 > 40);
  
    Console.WriteLine($"resultado {asignatura1.CalcularNotaFinal()}");



Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("****************");
Console.WriteLine("");

asignatura1.Imprimir();

Console.WriteLine("");
Console.WriteLine("****************");
Console.WriteLine("");
Console.WriteLine("");












