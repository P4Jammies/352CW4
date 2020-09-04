using System;

namespace ShapeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeType type;
            Console.WriteLine("What shape would you like?\n" +
                              "1. Line\n" +
                              "2. Circle\n" +
                              "3. Rectangle\n");
            type = (ShapeType) Convert.ToInt32(Console.ReadLine());

            ShapeFactory factory = new ShapeFactory();
            factory.getShape(type);
        }
    }
    class ShapeFactory
    {
        public GeometricShape getShape(ShapeType type)
        {
            GeometricShape shape;

            if (type == LINE)
                shape = new Line();
            else if (type = CIRCLE)
                shape = new Circle();
            else if (type = RECTANGLE)
                shape = new Rectangle();
            else
                return null;

            return shape;
        }
    }
    public enum ShapeType
    {
        LINE=1, CIRCLE=2, RECTANGLE=3, TRIANGLE=0
    }
    abstract class GeometricShape
    {
        public void draw()
        {
            Console.WriteLine("<Shape> is drawn.");
        }
    }
    class Line : GeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Line is drawn.");
        }
    }
    class Circle : GeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Circle is drawn.");
        }
    }
    class Rectangle : GeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle is drawn.");
        }
    }
}
