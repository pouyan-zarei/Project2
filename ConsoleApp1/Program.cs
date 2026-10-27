using System.Formats.Asn1;

Console.Clear();
Console.Write("Number1/3: ");
var Number1=Convert.ToDouble(Console.ReadLine());
Console.Write("Number2/3: ");
var Number2=Convert.ToDouble(Console.ReadLine());
Console.Write("Number3/3: ");
var Number3=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The average is: ");
Console.Write((Number1+Number2+Number3)/3);