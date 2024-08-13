






using System;
using System.Security.Cryptography.X509Certificates;


namespace ConsoleApp1
{
    public class Asignatura:Alumno,IAsignatura
    {


        public int N1;
        public int N2;
        public int N3;
        public string NombreAsignatura {  get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }




        //1.CalcularNotaFinal(): Método de tipo double, este método sumará las 3 notas parciales y retorna la nota final (1%)

       public double CalcularNotaFinald(int N1, int N2 , int N3)
        {

            return N1 + N2 + N3;


        }


        public double CalcularNotaFinal()
        {

            return N1 + N2 + N3;


        }



        public void Imprimir()
        {

            Console.WriteLine("Nombre dek estudiante: "+ NombreAlumno);
            Console.WriteLine("Numero de cuenta: " + NumeroCuenta);
            Console.WriteLine("Correo electronico: " + Email);
            Console.WriteLine("Nombre de Clase: " + NombreAsignatura);
            Console.WriteLine("Horario: " + Horario);
            Console.WriteLine("Nombre Del Docente: " + NombreDocente);
            Console.WriteLine("La Nota Final es: " + CalcularNotaFinal());
            Console.WriteLine("La Nota Final es: " + CalcularNotaFinald(N1,N2,N3));
          
            






        }




    }
}
