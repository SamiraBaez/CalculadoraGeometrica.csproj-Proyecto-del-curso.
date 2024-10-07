using System;

namespace CalculadoraGeometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Operaciones Geométricas");
            Console.WriteLine("Elija una figura: ");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Círculo");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Rectángulo");
            Console.WriteLine("5. Trapecio");
            int opcion = int.Parse(Console.ReadLine());

            Forma forma = null;

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el lado del cuadrado: ");
                    double lado = double.Parse(Console.ReadLine());
                    forma = new Cuadrado(lado);
                    break;
                case 2:
                    Console.Write("Ingrese el radio del círculo: ");
                    double radio = double.Parse(Console.ReadLine());
                    forma = new Circulo(radio);
                    break;
                case 3:
                    Console.Write("Ingrese la base del triángulo: ");
                    double baseTriangulo = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    double altura = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese los lados del triángulo (lado1, lado2, lado3): ");
                    double lado1 = double.Parse(Console.ReadLine());
                    double lado2 = double.Parse(Console.ReadLine());
                    double lado3 = double.Parse(Console.ReadLine());
                    forma = new Triangulo(baseTriangulo, altura, lado1, lado2, lado3);
                    break;
                case 4:
                    Console.Write("Ingrese el largo del rectángulo: ");
                    double largo = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el ancho del rectángulo: ");
                    double ancho = double.Parse(Console.ReadLine());
                    forma = new Rectangulo(largo, ancho);
                    break;
                case 5:
                    Console.Write("Ingrese la base mayor del trapecio: ");
                    double baseMayor = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la base menor del trapecio: ");
                    double baseMenor = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del trapecio: ");
                    double alturaTrapecio = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese los lados del trapecio (lado1, lado2): ");
                    double ladoTrapecio1 = double.Parse(Console.ReadLine());
                    double ladoTrapecio2 = double.Parse(Console.ReadLine());
                    forma = new Trapecio(baseMayor, baseMenor, alturaTrapecio, ladoTrapecio1, ladoTrapecio2);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            // Mostrar resultados
            Console.WriteLine($"Área: {forma.CalcularArea()}");
            Console.WriteLine($"Perímetro: {forma.CalcularPerimetro()}");

            // Preguntar si el usuario quiere realizar otro cálculo
            Console.WriteLine("¿Desea realizar otro cálculo? (s/n)");
            char respuesta = char.Parse(Console.ReadLine());

            while (respuesta == 's' || respuesta == 'S')
            {
                // Repetir el proceso
                Console.WriteLine("Elija una figura: ");
                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Círculo");
                Console.WriteLine("3. Triángulo");
                Console.WriteLine("4. Rectángulo");
                Console.WriteLine("5. Trapecio");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el lado del cuadrado: ");
                        lado = double.Parse(Console.ReadLine());
                        forma = new Cuadrado(lado);
                        break;
                    case 2:
                        Console.Write("Ingrese el radio del círculo: ");
                        radio = double.Parse(Console.ReadLine());
                        forma = new Circulo(radio);
                        break;
                    case 3:
                        Console.Write("Ingrese la base del triángulo: ");
                        baseTriangulo = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura del triángulo: ");
                        altura = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese los lados del triángulo (lado1, lado2, lado3): ");
                        lado1 = double.Parse(Console.ReadLine());
                        lado2 = double.Parse(Console.ReadLine());
                        lado3 = double.Parse(Console.ReadLine());
                        forma = new Triangulo(baseTriangulo, altura, lado1, lado2, lado3);
                        break;
                    case 4:
                        Console.Write("Ingrese el largo del rectángulo: ");
                        largo = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el ancho del rectángulo: ");
                        ancho = double.Parse(Console.ReadLine());
                        forma = new Rectangulo(largo, ancho);
                        break;
                    case 5:
                        Console.Write("Ingrese la base mayor del trapecio: ");
                        baseMayor = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la base menor del trapecio: ");
                        baseMenor = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura del trapecio: ");
                        alturaTrapecio = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese los lados del trapecio (lado1, lado2): ");
                        ladoTrapecio1 = double.Parse(Console.ReadLine());
                        ladoTrapecio2 = double.Parse(Console.ReadLine());
                        forma = new Trapecio(baseMayor, baseMenor, alturaTrapecio, ladoTrapecio1, ladoTrapecio2);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        return;
                }

                // Mostrar resultados
                Console.WriteLine($"Área: {forma.CalcularArea()}");
                Console.WriteLine($"Perímetro: {forma.CalcularPerimetro()}");
                
                // Preguntar si el usuario quiere realizar otro cálculo
                Console.WriteLine("¿Desea realizar otro cálculo? (s/n)");
                respuesta = char.Parse(Console.ReadLine());
            }
        }
    }
}
