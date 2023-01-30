using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        square.SetShapeName("Square");
        square.SetColor("Blue");
        square.SetSide(4);

        Rectangle rectangle = new Rectangle();
        rectangle.SetShapeName("Rectangle");
        rectangle.SetColor("Green");
        rectangle.SetLength(4);
        rectangle.SetWidth(2);

        Circle circle = new Circle();
        circle.SetShapeName("Circle");
        circle.SetColor("purple");
        circle.SetRadius(5);

        DisplayShapeInfo(square);
        DisplayShapeInfo(rectangle);
        DisplayShapeInfo(circle);


    }
    public static void DisplayShapeInfo(Shapes shape)
    {
        Console.WriteLine($"{shape.GetsShapeName()} is {shape.GetColor()} and its area is {shape.GetArea()}");

    }
}