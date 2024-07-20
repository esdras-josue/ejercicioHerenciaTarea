using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioHerenciaTarea
{
    public class Operaciones
    {
        public double AreaCuadrado(double lado)
        {
            double area = lado * lado;
            return area;
        }

        public double VolumenCubo(double lado)
        {
            double area = lado * lado * lado;
            return area;
        }

        public double PerimetroCuadrado(double lado)
        {
            double perimetro = 4 * lado;
            return perimetro;
        }
    }
}
