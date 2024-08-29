namespace Var1Task3.classes.classes;

public class Shape
{
    public string color { get; set; }
    public string typeShape { get; set; }
        
    public Shape()
    {
        color = "yellow";
        typeShape = "rectangle";
        
    }

    protected Shape(string color, string typeShape)
    {
        this.color = color;
        this.typeShape = typeShape;
    }

    public virtual void draw()
    {
        Console.WriteLine($"Color: {color} and Shape: {typeShape}");
    }

    public virtual double area()
    {
        return area();
    }

    public virtual double perimeter()
    {
        return perimeter();
    }
}

public class Circle : Shape, Drawable
{
    public double radius { get; set; }

    public Circle(double radius, string color, string typeShape) : base(color, typeShape)
    {
        this.radius = radius;
    }

    public Circle()
    {
        radius = 5;
    }

    public double areaFind()
    {
        double pi = 3.14;
        return radius * pi;
    }
    
    public override void draw()
    {
        Console.WriteLine($"Color: {color} and Type: {typeShape}");
    }

    public override double area()
    {
        return areaFind();
    }

    public override double perimeter()
    {
        return (2 * areaFind()) * 2;
    }
}