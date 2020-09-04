using System;

namespace ShapeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                ShapeType type;
                Console.WriteLine("What shape would you like?\n" +
                                  "1. Line\n" +
                                  "2. Circle\n" +
                                  "3. Rectangle\n");
                type = (ShapeType) i;

                ShapeFactory factory = new ShapeFactory();
                factory.getShape(type).draw();
            }
        }
    }
    public enum ShapeType
    {
        LINE = 1, CIRCLE = 2, RECTANGLE = 3, TRIANGLE = 0
    }
    class ShapeFactory
    {
        public GeometricShape getShape(ShapeType type)
        {
            GeometricShape shape;

            if (type == (ShapeType) 1)
                shape = new Line();
            else if (type == (ShapeType) 2)
                shape = new Circle();
            else if (type == (ShapeType) 3)
                shape = new Rectangle();
            else
                return null;

            return shape;
        }
    }
    abstract class GeometricShape
    {
        public virtual void draw()
        {
            Console.WriteLine("<Shape> is drawn.\n");
        }
    }
    class Line : GeometricShape
    {
        public override void draw()
        {
            Console.WriteLine("Line is drawn.\n");
        }
    }
    class Circle : GeometricShape
    {
        public override void draw()
        {
            Console.WriteLine("Circle is drawn.\n");
        }
    }
    class Rectangle : GeometricShape
    {
        public override void draw()
        {
            Console.WriteLine("Rectangle is drawn.\n");
        }
    }
}
