
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

            RegularPolygon rp1 = new RegularPolygon();
            RegularPolygon rp2 = new RegularPolygon(6,4);
            RegularPolygon rp3 = new RegularPolygon(10, 4, 5.6, 7.8);
            Console.WriteLine();
            Console.WriteLine($"Kerület: {rp1.getPerimeter()}, Terület: {rp1.getArea()}");
            Console.WriteLine($"Kerület: {rp2.getPerimeter()}, Terület: {rp2.getArea()}");
            Console.WriteLine($"Kerület: {rp3.getPerimeter()}, Terület: {rp3.getArea()}");
            Console.WriteLine();
            LinearEquation le = new LinearEquation(7,6,5,5,6,7);
            Console.WriteLine(le.ToString());
            Console.WriteLine();
            Console.WriteLine("Enter the number of rows and columns of the array: ");
            int row, column;
            string[] bemenet = Console.ReadLine().Split(' ');
            row = Convert.ToInt32(bemenet[0]);
            column = Convert.ToInt32(bemenet[1]);
            double[,] array = new double[row, column];
            Console.WriteLine("Enter the array:");
            for(int i=0; i < row; i++)
            {
                bemenet = Console.ReadLine().Split(' ');
                for(int j = 0; j < column; j++)
                {
                    array[i,j] = Convert.ToDouble(bemenet[j]);
                }
            }
            Location l = Location.locateLargest(array);
            Console.WriteLine($"The location of the largest element is {l.maxValue} at ({l.row},{l.column})");
        }
}
}
