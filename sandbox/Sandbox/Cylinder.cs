class Cylinder
{
    private Circle _circle;
    private double _height;

    public void SetCircle(Circle circle)
    {
        _circle = circle;
        SetHeight(10); // Assuming this call to SetHeight(10) is intentional here.
    }

    public void SetHeight(double height)
    {
        if (height < 0)
        {
            Console.WriteLine("Error, cannont set a negative value.");
            return;
        }
        _height = height;
    }

    public double GetVolume()
    {
        // double radius = _circle.GetRadius();
        return _circle.GetArea() * _height;
        // return Math.PI * radius * radius * _height;
    }
}