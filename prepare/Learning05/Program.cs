using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square sq = new Square("blue", 8);
        shapes.Add(sq);

        Rectangle rect = new Rectangle("yellow", 5, 7);
        shapes.Add(rect);

        Circle circle = new Circle("red", 6);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Shape color: {color}, Shape area: {area}");

        }
    }
}