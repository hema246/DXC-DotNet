// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Xml.Schema;

Console.WriteLine("Enter the Student ID");
int ID=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Student Name");
String Name=Console.ReadLine();
Console.WriteLine("Enter the Student Age");
int Age=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Mark1:");
int Mark1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Mark2:");
int Mark2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Mark3:");
int Mark3 = Convert.ToInt32(Console.ReadLine());

int Total=Mark1+Mark2+Mark3;
double Percentage = Total / 3;
Console.WriteLine("Your Total Score:" + Total);
Console.WriteLine("Your Percentage :" + Percentage);


if (Percentage > 50)
{ 
    Console.WriteLine("Your Result for the Exam is PASS");
    if (Percentage >= 90)
        Console.WriteLine("Your Grade is" + "A");
    else if (Percentage >= 80 && Percentage <= 89)
        Console.WriteLine("Your Grade is" + "B");
    else if (Percentage >= 70 && Percentage <= 79)
        Console.WriteLine("Your Grade is" + "C");
    else if (Percentage >= 60 && Percentage <= 69)
        Console.WriteLine("Your Grade is " + "D");
    else if (Percentage >= 50 && Percentage <= 59)
        Console.WriteLine("Your Grade is " + "E");
    else
        Console.WriteLine("Your Result for the Exam is FAIL");

}
else
{
    Console.WriteLine("Your Result for the Exam is FAIL");
}
