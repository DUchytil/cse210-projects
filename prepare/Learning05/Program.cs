

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Shape shape1 = new Square("Red", 22);
        Shape shape2 = new Rectangle("Blue", 22, 33);
        Shape shape3 = new Circle("Purple", 2);

        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor()); 
            Console.WriteLine(shape.GetArea()); 
        }

    }
}