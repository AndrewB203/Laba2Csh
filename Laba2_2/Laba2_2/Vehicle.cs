using System;

public class Vehicle
{
	public double X { get; set; }
	public double Y { get; set; }
	public double Price { get; set; }
	public double Speed{ get; set; }
	public int Year { get; set; }

	public Vehicle(double x, double y, double price, double speed, int year)
	{
		X = x;
		Y = y;
		Price = price;
		Speed = speed;
		Year = year;
	}
	public virtual void DisplayInfo()
	{
		Console.WriteLine($"Coordinates: ({X}, {Y})");
		Console.WriteLine($"Price: {Price}");
		Console.WriteLine($"Speed: {Speed} km/h");
		Console.WriteLine($"Year:{Year}");
	}

}

public class Plane : Vehicle
{
	public double Height { get; set; }
	public int Number { get; set; }
	
	public Plane(double x, double y, double price, double speed, int year, double height, int number) : base(x, y, price, speed, year)
	{
		Height = height;
		Number = number;
	}
	public override void DisplayInfo()
	{
		base.DisplayInfo();
		Console.WriteLine($"Height: {Height} meters");
		Console.WriteLine($"Number: {Number}");
	}
}

public class Car : Vehicle
{
	public Car(double x, double y, double price, double speed, int year) : base(x, y, price, speed, year)
	{ }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
    }
}
public class Ship : Vehicle
{
	public double Passengers {get; set; }
	public string Port { get; set; }

	public Ship (double x, double y, double price, double speed, int year, double passengers, string port) : base(x, y, price, speed, year)
	{
		Passengers = passengers;
		Port = port;
	}

	public override void DisplayInfo()
	{
		base.DisplayInfo();
		Console.WriteLine($"Passengers: {Passengers}");
		Console.WriteLine($"Port: {Port}");
	}
}


