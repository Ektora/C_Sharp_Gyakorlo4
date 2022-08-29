
namespace Gyakorlo4 { 
public class Gyakorlo4
{
    public static void Main(string[] args)
    {
            Rectangle r1 = new Rectangle(40.0, 4.0);
            Rectangle r2 = new Rectangle(35.9, 3.5);
            Console.WriteLine($"{r1.height} {r1.width} {r1.getArea()} {r1.getPerimeter()}");
            Console.WriteLine($"{r2.height} {r2.width} {r2.getArea()} {r2.getPerimeter()}");
        }
}
}
