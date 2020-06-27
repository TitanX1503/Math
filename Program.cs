using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            //la raiz del numero
            System.Console.WriteLine("la raiz cuadrada de 23 = " + System.Math.Sqrt(23));

            //diferencia de numeros mayores
            System.Console.WriteLine("el numero mas grande entere 13 y 20 = " + System.Math.Max (13, 20));

            //redondeo
            System.Console.WriteLine("el redondeo de 3.67 = " + System.Math.Round(3.67));

            //quitar las decimales
            System.Console.WriteLine("sin las decimales 543.5783753 = " + System.Math.Truncate(543.5783753));

            //potencia del numero
            int numero = 5, potencia = 3;
            Double elevadoAlCubo = System.Math.Pow(numero, potencia);
            System.Console.WriteLine(string.Format("{0} elevado a {1} potencia es {2}", numero, potencia, elevadoAlCubo));

            //agregar el signo al numero
            System.Console.WriteLine("el signo de 56 = " + System.Math.Sign(56));

            //numero mayor sin tomar en cuenta el signo
            System.Console.WriteLine("el numero mayot sin tomar en cuenta el signo entre -15 y 12 = " + System.Math.Max(System.Math.Abs(-15), System.Math.Abs(12)));
        }
    }
}
