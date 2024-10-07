using System;

namespace CalculadoraGeometrica
{
    // Clase base
    public abstract class Forma
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }

    // Clase para el Cuadrado
    public class Cuadrado : Forma
    {
        public double Lado { get; set; }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }

    // Clase para el Círculo
    public class Circulo : Forma
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }

    // Clase para el Triángulo
    public class Triangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public Triangulo(double baseTriangulo, double altura, double lado1, double lado2, double lado3)
        {
            Base = baseTriangulo;
            Altura = altura;
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }

    // Clase para el Rectángulo
    public class Rectangulo : Forma
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public override double CalcularArea()
        {
            return Largo * Ancho;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }
    }

    // Clase para el Trapecio
    public class Trapecio : Forma
    {
        public double BaseMayor { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public Trapecio(double baseMayor, double baseMenor, double altura, double lado1, double lado2)
        {
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Altura = altura;
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public override double CalcularArea()
        {
            return ((BaseMayor + BaseMenor) * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return BaseMayor + BaseMenor + Lado1 + Lado2;
        }
    }
}
