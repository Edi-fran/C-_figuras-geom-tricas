using System;

namespace FigurasGeometricas
{
    // Clase base para figuras geométricas
    abstract class Figura
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }

    // Clase Cuadrado
    class Cuadrado : Figura
    {
        private double lado;

        // Constructor
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        // Cálculo del área
        public override double CalcularArea()
        {
            return lado * lado; // Área = lado^2
        }

        // Cálculo del perímetro
        public override double CalcularPerimetro()
        {
            return 4 * lado; // Perímetro = 4 * lado
        }
    }

    // Clase Rectángulo
    class Rectangulo : Figura
    {
        private double baseRectangulo;
        private double altura;

        // Constructor
        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        // Cálculo del área
        public override double CalcularArea()
        {
            return baseRectangulo * altura; // Área = base * altura
        }

        // Cálculo del perímetro
        public override double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + altura); // Perímetro = 2 * (base + altura)
        }
    }

    // Clase principal para gestionar la lógica del programa
    class FigurasGeometricasApp
    {
        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("==== UNIVERSIDAD ESTATAL AMAZONICA ====");
            Console.WriteLine();
            Console.WriteLine("==== MENÚ DE FIGURAS GEOMÉTRICAS ====");
            Console.WriteLine("1. Calcular área y perímetro de un cuadrado");
            Console.WriteLine("2. Calcular área y perímetro de un rectángulo");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
        }

        static void CalcularCuadrado()
        {
            Console.Clear();
            Console.Write("Ingrese el lado del cuadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());
            Cuadrado cuadrado = new Cuadrado(lado);

            Console.WriteLine($"\nÁrea del cuadrado: {cuadrado.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del cuadrado: {cuadrado.CalcularPerimetro():F2}");
        }

        static void CalcularRectangulo()
        {
            Console.Clear();
            Console.Write("Ingrese la base del rectángulo: ");
            double baseRectangulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la altura del rectángulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Rectangulo rectangulo = new Rectangulo(baseRectangulo, altura);

            Console.WriteLine($"\nÁrea del rectángulo: {rectangulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del rectángulo: {rectangulo.CalcularPerimetro():F2}");
        }

        static void EjecutarAplicacion()
        {
            int opcion;

            do
            {
                MostrarMenu();
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CalcularCuadrado();
                        break;
                    case 2:
                        CalcularRectangulo();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                if (opcion != 3)
                {
                    Console.WriteLine("\nPresione cualquier tecla para regresar al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 3);

            Console.WriteLine("Programa finalizado. ¡Gracias por usar el sistema!");
        }

        static void Main(string[] args)
        {
            EjecutarAplicacion();
        }
    }
}

