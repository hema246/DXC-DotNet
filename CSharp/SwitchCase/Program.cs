// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter First Number");
int Num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number");
int Num2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the operator");

Char Operator=Convert.ToChar(Console.ReadLine());

int Result = 0;

switch (Operator)
{
    case'+': 

    Result = Num1 + Num2;
    Console.WriteLine("Result is:" + Result);
    break; 

    case'-': 

    Result = Num1 - Num2;
    Console.WriteLine("Result is:" + Result);
    break;

    case '*':
    Result = Num1 * Num2;
    Console.WriteLine("Result is: "+Result);
    break;

    case'/':
    Result = Num1 / Num2;
    Console.WriteLine("Result is " + Result);
    break;

    case'%':
    Result = Num1 % Num2;
    Console.WriteLine("Result is:" + Result);
    break;
    
    default:
    Console.WriteLine("Enter correct input");
    break;
}