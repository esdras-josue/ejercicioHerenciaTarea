using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioHerenciaTarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Figuras cuadrado = new Figuras();
           Figuras cubo = new Figuras();

            Console.WriteLine("Opereciones Geometricas");
            Console.WriteLine();

            Console.WriteLine("Ingrese un numero para calcular el area de un cuadrado");
            double AreaCuadrado = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero para calcular el perimetro de un cuadrado");
            double periemetroCuadrado = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero para calcular el volumen de un cubo");
            double volumenCubo = double.Parse(Console.ReadLine());

            Console.WriteLine();
            cuadrado.Imprimir(AreaCuadrado, periemetroCuadrado, volumenCubo);

            Console.ReadKey();

    



            
        }
    }
}
