using interface_example;
using interface_example.Class_Cars;


//Seyed Erfan Noorbakhsh//


Benz benz = new Benz();
Bmw bmw = new Bmw();
Pride pride = new Pride();


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(benz.GetCarName("Benz"));
Console.WriteLine("maximum passenger is: " +benz.MaximumPassenger(5)+ " persons");
Console.ResetColor();
benz.Speed = 140;


Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("*********************************************************************");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(bmw.GetCarName("BMW"));
Console.WriteLine("maximum passenger is: " + bmw.MaximumPassenger(5) + " persons");
Console.ResetColor();
bmw.Speed = 135;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("*********************************************************************");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(pride.GetCarName("Pride"));
Console.WriteLine("maximum passenger is: " + pride.MaximumPassenger(8) + " persons");
Console.ResetColor();
pride.Speed = 140;
