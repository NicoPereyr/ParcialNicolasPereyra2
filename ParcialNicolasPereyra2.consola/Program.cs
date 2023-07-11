using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialNicolasPereyra2.consola
{
    internal class Program
    {
        static void Main(string[] args)
            {
                double area, volumen, h, l, arista;
                int contador, cantidadPiramides;
                cantidadPiramides = 0;

                do
                {
                    Console.Write("Ingrese el valor de la altura: ");
                    h = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese el valor de la base: ");
                    l = Convert.ToDouble(Console.ReadLine());

                    area = CalcularArea(h, l);
                    arista = CalcularArista(h, l);
                    volumen = CalcularVolumen(h, l);
                    cantidadPiramides++;

                    Console.WriteLine("Área= {0} Volumen= {1} Arista= {2}", area, volumen, arista);
                    Console.WriteLine("La cantidad de piramides ingresadas es: {0}", cantidadPiramides);
            }
                while (h != 0 && l != 0);

            
            }

            private static double CalcularArea(double altura, double baseTriangulo)
            {
                return (baseTriangulo * baseTriangulo) + (2 * baseTriangulo * altura);
            }

            private static double CalcularArista(double altura, double baseTriangulo)
            {
                return Math.Sqrt((baseTriangulo * baseTriangulo) + (altura * altura));
            }

            private static double CalcularVolumen(double altura, double baseTriangulo)
            {
                return (baseTriangulo * baseTriangulo * altura) / 3;
            }
        }

    }


