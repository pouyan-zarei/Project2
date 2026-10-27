using System.Formats.Asn1;

Console.Clear();
Console.Write("Radius: ");
var Radius=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Perimeter is: ");
Console.Write(2*3.141592653589793*Radius);
Console.WriteLine("Area is: ");
Console.Write(Radius*Radius*3.14592653589793);