using System;

namespace ConsoleApplication
{
    // Abstracte klasse Shape
    abstract class Shape
    {
        protected string color;

        public Shape(string color)
        {
            this.color = color;
        }

        // Abstracte methode draw
        public abstract string draw();
    }

    // Klassen Circle en Square die overerven van Shape
    class Circle : Shape
    {
        private double radius;

        public Circle(string color, double radius) : base(color)
        {
            this.radius = radius;
        }

        // Implementatie van de abstracte methode draw
        public override string draw()
        {
            return "Dit is een cirkel met de kleur " + this.color + " en de straal " + this.radius;
        }
    }

    class Square : Shape
    {
        private double sideLength;

        public Square(string color, double sideLength) : base(color)
        {
            this.sideLength = sideLength;
        }

        // Implementatie van de abstracte methode draw
        public override string draw()
        {
            return "Dit is een vierkant met de kleur " + this.color + " en de zijde lengte " + this.sideLength;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Maak objecten aan van Circle en Square klassen
            Circle circle1 = new Circle("rood", 5);
            Circle circle2 = new Circle("blauw", 7);

            Square square1 = new Square("groen", 4);
            Square square2 = new Square("geel", 6);

            // Toon resultaten in de console
            Console.WriteLine(circle1.draw());
            Console.WriteLine(circle2.draw());
            Console.WriteLine(square1.draw());
            Console.WriteLine(square2.draw());

            // Toon naam in de console
            Console.WriteLine("Eren");

            Console.ReadLine(); // Voorkom dat de console onmiddellijk sluit
        }
    }
}
