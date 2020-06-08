using System;

namespace ResolucionEjercicio03Tp02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Resolución de una ecuación cuadrática";
            Console.Write("Ingrese el valor del coeficiente cuadrático:");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                if (a!=0)
                {
                    Console.Write("Ingrese el valor del coeficiente lineal:");
                    if (int.TryParse(Console.ReadLine(), out int b))
                    {
                        Console.Write("Ingrese el valor del coeficiente independiente:");
                        if (int.TryParse(Console.ReadLine(), out int c))
                        {
                            var discriminante = Math.Pow(b, 2) - 4 * a * c;
                            if (discriminante==0)
                            {
                                double raiz1 = CalcularRaizUnica(a, b);
                                Console.WriteLine($"La ecuación tiene una sola solución y es {raiz1}");
                            }else if (discriminante>0)
                            {
                                HallarSoluciones(a, b, discriminante);
                            }
                            else
                            {
                                HallarSolucionesImaginarias(a, b, discriminante);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Coeficiente independiente a mal ingresado");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Coeficiente lineal a mal ingresado");
                    }
                }
                else
                {
                    Console.WriteLine("El coeficiente cuadrático no puede ser 0");
                }
            }
            else
            {
                Console.WriteLine("Coeficiente a mal ingresado");
            }
            

		}

        private static void HallarSolucionesImaginarias(int nroA, int nroB, double discriminante)
        {
            double parteReal = -nroB / 2 * nroA;
            double parteImaginaria = Math.Sqrt(Math.Abs(discriminante)) / 2 * nroA;
            Console.WriteLine("La ecuación tiene 2 soluciones en el campo de los números imaginarios");
            Console.WriteLine($"Solución 1={parteReal}+{parteImaginaria}i");
            Console.WriteLine($"Solución 2={parteReal}-{parteImaginaria}i");

        }

        private static void HallarSoluciones( int nroA,  int nroB,  double discriminante)
        {
            double raiz1= (-nroB + Math.Sqrt(discriminante)) / 2 * nroA;
            double raiz2 = (-nroB - Math.Sqrt(discriminante)) / 2 * nroA;
            Console.WriteLine("La ecuación tiene 2 soluciones");
            Console.WriteLine($"Solución 1={raiz1}");
            Console.WriteLine($"Solución 2={raiz2}");

        }

        private static double CalcularRaizUnica(int nroA,  int nroB)
        {
            return -nroB / 2 * nroA;
        }
    }
}
