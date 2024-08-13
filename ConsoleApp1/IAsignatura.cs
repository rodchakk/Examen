

//1.CalcularNotaFinal(): Método de tipo double, este método sumará las 3 notas parciales y retorna la nota final (1%)
//2.	CalcularNotaFinal (Con 3 parámetros de las notas): Método de tipo double, este método sumará las 3 notas parciales a partir de los parámetros y retorna la nota final (1%)
//3.	MensajeNotaFinal(double notaFinal): Método tipo string, este método retornara el mensaje de acuerdo a la nota final, más detalles de la misma en la implementación (1%)
//4.	Imprimir(): Método de tipo void que va a mostrar en pantalla los datos del alumno, datos de la asignatura y la nota final (1%)






using System;


namespace ConsoleApp1
{
    public interface IAsignatura
    {

        double CalcularNotaFinal();
        string MensajeNotaFinal();
        void Imprimir();

    }
}
