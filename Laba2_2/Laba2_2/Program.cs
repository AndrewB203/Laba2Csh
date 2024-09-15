namespace Lab2_2;

class Program
{
    static void Main(string[] args)
    {
        Plane plane = new Plane(100, 200, 1000000, 900, 2020, 10000, 200);
        Car car = new Car(10, 10, 30000, 120, 2019);
        Ship ship = new Ship(23, 47, 234000000, 100, 2010, 28000, "St.Peterbur");

        Console.WriteLine("Plane Information:");
        plane.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Car Information: ");
        car.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Ship Information: ");
        ship.DisplayInfo();
        Console.WriteLine();
    }
}