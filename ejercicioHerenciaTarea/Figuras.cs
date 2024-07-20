using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioHerenciaTarea
{
    public class Figuras : Operaciones
    {

      
        public void Imprimir(double area, double perimetro,double volumen)
        {
            double areaCuadrado = AreaCuadrado(area);
            double perimetroCuadrado = PerimetroCuadrado(perimetro);
            double volumenCubo = VolumenCubo(volumen);

            Console.WriteLine($"Area del Cuadrado: {areaCuadrado}");
            Console.WriteLine($"Perimetro del Cuadrado: {perimetroCuadrado}");
            Console.WriteLine($"Volumen del Cubo: {volumenCubo}");
        }
    }
}
