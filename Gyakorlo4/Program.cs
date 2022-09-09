
using System.Runtime.CompilerServices;

namespace Gyakorlo4 { 
public class Gyakorlo4
{
    public static void Main(string[] args)
    {
            Rectangle r1 = new Rectangle(40.0, 4.0);
            Rectangle r2 = new Rectangle(35.9, 3.5);
            Console.WriteLine($"{r1.height} {r1.width} {r1.getArea()} {r1.getPerimeter()}");
            Console.WriteLine($"{r2.height} {r2.width} {r2.getArea()} {r2.getPerimeter()}");

            Account Számla = new Account(1122, 20000);
            Számla.AnnualInterestRate = 4.5;
            Számla.withdraw(2500);
            Számla.deposit(3000);
            Console.WriteLine($"{Számla.Balance} - {Számla.getMonthlyInterestRate()} - {Számla.DateCreated}");

            Fan f1 = new Fan();
            f1.Speed = Fan.FAST;
            f1.Radius = 10;
            f1.Color = "yellow";
            f1.On = true;
            Fan f2 = new Fan();
            f2.Speed = Fan.MEDIUM;
            f2.Radius = 5;
            f2.Color = "blue";
            f2.On = false;
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());

        }
}
}
