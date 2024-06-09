namespace Shape;
class Program
{
    static void Main(string[] args)
    {

        Triangle triangle = new Triangle { Side = 5, Height = 10 };
        Console.WriteLine(triangle.CalculateArea());

        Circle circle = new Circle { Radius = 5 };
        Console.WriteLine(circle.CalculateArea());

        Square square = new Square { Side = 5 };
        Console.WriteLine(square.CalculateArea());
    }
}