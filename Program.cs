using Var1Task3.classes.classes;

namespace Var1Task3.classes;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(20,"Yellow", "circle");

        Console.WriteLine($"the perimter of circle is: {circle.perimeter()}");
        
        Console.WriteLine($"the area of circle is: {circle.area()}");
        
    }
}