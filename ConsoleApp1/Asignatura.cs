





//Atributo / Propiedad    Tipo de dato	Encapsulado
//N1	int	No
//N2	int	No
//N3	int	No
//NombreAsignatura	string	Si
//Horario	string	Si
//NombreDocente	string	Si





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

       public double CalcularNotaFinal(double n1, double n2 , double n3)
        {

            return n1 + n2 + n3;


        }


        public double CalcularNotaFinal()
        {

            return N1 + N2 + N3;


        }



        public void Imprimir()
        {

            Console.WriteLine(NombreAlumno);
            Console.WriteLine(NumeroCuenta);
            Console.WriteLine(Email);
            Console.WriteLine(NombreAsignatura);
            Console.WriteLine(Horario);
            Console.WriteLine(NombreDocente);
            Console.WriteLine(N1);
            Console.WriteLine(N2);
            Console.WriteLine(N3);

            



        }




    }
}
