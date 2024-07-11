using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [
            new Square("Red", 13),
            new Rectangle("Green", 4.5, 17),
            new Circle("Blue", 7.5) ];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The shape is {shape.GetColor()}, and its area is {shape.GetArea()}.");
        }
    }
}