// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Enter three numbers");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine()); 
int num3=Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3) 
Console.WriteLine("Num1 is Largest");

else if (num2 > num1 && num2 > num3)
    Console.WriteLine("Num2  is Largest");
else
    Console.WriteLine("Num3 is Largest");
