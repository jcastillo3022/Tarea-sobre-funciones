using System;

namespace Tarea_sobre_funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tarea sobre funciones de Phyton a c#
           //area del circulo:
            float radio = 0;
            double pi = 3.141516;
            Console.Write("ingrese el radio del circulo");
            radio = float.Parse(Console.ReadLine());
            double area = pi * (radio * radio);
            Console.WriteLine("el area del circulo es :" +area);

            Console.ReadKey();
            // Area de un rectangulo
            Console.Write("Ingresa la base del rectangulo:");
            int base_r = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la altura del rectangulo");
            int altura = int.Parse(Console.ReadLine());
            double area_rectangulo = (base_r * altura) ;
            Console.Write("El area del rectangulo es :" + area + "cm2");
            Console.ReadKey();


             // area del triangulo
               
            Console.Write("ingrese la base del triangulo");
            int base_ = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la altura del triangulo");
            int altura_ = int.Parse(Console.ReadLine());
            double area_tringulo = (base_ * altura_) / 2;
            Console.WriteLine("La area del triangulo es :"+area_tringulo);
            Console.ReadKey();

           
        }
    }
}
