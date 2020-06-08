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
            
            //Escribir "La ecuación tiene una sola solución y es ",RaizUnica;
            //SiNo
            //    Si Discriminante > 0 Entonces
            //CalcularRaicesEcuacionCuadratica(a, b, Discriminante);
            //SiNo
            //CalcularRaicesImaginarias(a, b, Discriminante);
            //FinSi
            //    FinSi


            //FinSi

		}

        private static double CalcularRaizUnica(int nroA,  int nroB)
        {
            return -nroB / 2 * nroA;
        }
    }
}
