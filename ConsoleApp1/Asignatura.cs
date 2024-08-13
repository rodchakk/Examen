






using Microsoft.VisualBasic;
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





       public double CalcularNotaFinald(int N1, int N2 , int N3)
        {

            return N1 + N2 + N3;


        }


        public double CalcularNotaFinal()
        {

            return N1 + N2 + N3;



        }



        public string MensajeNotaFinal()
        {


            string msg="";
//1.De 0 % a 59 %: Reprobado
//2.De 60 % a 79 %: Bueno
//3.De 80 % a 89 %: Muy Bueno
//4.De 90 % a 100 % Sobresaliente

            if (CalcularNotaFinal() <= 59)
            {

                msg = "Aprobado";

            } else if(CalcularNotaFinal() <= 79)
            {
                msg = "Bueno";
            } else if(CalcularNotaFinal() <= 89)
            {
                msg = "Muy Bueno";
            } else if(CalcularNotaFinal() <= 100)
            {
                msg = "Sobresaliente";
            }else
            {
                msg = "Nota fuera de rango";
            }








            return msg;

        }






        public void Imprimir()
        {

            Console.WriteLine("Nombre dek estudiante: "+ NombreAlumno);
            Console.WriteLine("Numero de cuenta: " + NumeroCuenta);
            Console.WriteLine("Correo electronico: " + Email);
            Console.WriteLine("Nombre de Clase: " + NombreAsignatura);
            Console.WriteLine("Horario: " + Horario);
            Console.WriteLine("Nombre Del Docente: " + NombreDocente);
            Console.WriteLine("La Nota Final es: " + CalcularNotaFinal() + " " + MensajeNotaFinal());
            Console.WriteLine("La Nota Final es: " + CalcularNotaFinald(N1, N2, N3) + " " + MensajeNotaFinal());
            
            
          
          

        }








    }
}
