using System;

namespace InterfaceImplementation
{
    class Program
    {
        static int GetShapeCount()
        {
            Console.Write("\nhow many shapes? ");
            return int.Parse(Console.ReadLine());
        }
        static void PrintMenu()
        {
            Console.WriteLine("\n1. Circle");
            Console.WriteLine("2. Triangle");
        }
        static int GetChoice()
        {
            Console.Write("\nEnter Choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }
        static IShape CreateShape(int choice)
        {
            IShape shape = null;
            switch (choice)
            {
                case 1:
                    Console.Write("\nEnter Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shape = new Circle(radius);
                    break;

                case 2:
                    Console.Write("\nEnter Base: ");
                    double tbase = double.Parse(Console.ReadLine());
                    Console.Write("Enter Height: ");
                    double theight = double.Parse(Console.ReadLine());
                    shape = new Triangle(tbase, theight);
                    break;

                default:
                    break;
            }
            return shape;
        }
        static void CreateShapeStorage(out IShape[] shapes, int count)
        {
            shapes = new IShape[count];
        }
        static void AddShape(IShape[] shapes)
        {
            for (int i = 0; i < shapes.Length; i++)
            {
                PrintMenu();
                int choice = GetChoice();
                IShape shape = CreateShape(choice);
                shapes[i] = shape;
            }
        }
        static void PrintCalculatedArea(IShape[] shapes)
        {
            foreach (IShape shape in shapes)
            {
                if (shape != null)
                    Console.WriteLine($"Area of {shape.GetType().Name} is {shape.CalculateArea()}");
            }
        }
        static void Main()
        {
            int shapeCount = GetShapeCount();
            //IShape[] shapes;
            //CreateShapeStorage(shapes, shapeCount);
            CreateShapeStorage(out IShape[] shapes, shapeCount);
            AddShape(shapes);
            PrintCalculatedArea(shapes);
        }
    }
}
