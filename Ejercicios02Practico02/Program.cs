using Ejercicios02Practico02.POO;
using System;

namespace Ejercicios02Practico02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cono cono = new Cono();
                Console.WriteLine("Ingrese el valor de generatriz");
                var generatriz = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la altura");
                var altura = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el radio de giro ");
                var radiodegiro = double.Parse(Console.ReadLine());
                if(generatriz > 0 & altura > 0 & radiodegiro > 0 )
                {
                    cono.generatriz = generatriz;
                    cono.altura = altura;
                    cono.radiodegiro = radiodegiro;

                    Console.WriteLine($"El Volumen de un cono es {cono.GetVolumen()} ");
                    Console.WriteLine($"El Area de un cono es {cono.GetArea()} ");
                }
                else
                {
                    Console.WriteLine("Ingrese un numero mayor a 0");
                }
              

                
            }
            catch (FormatException)
            {

                Console.WriteLine("Valores invalidos");
            }
            Console.ReadLine();
        }
    }
}
