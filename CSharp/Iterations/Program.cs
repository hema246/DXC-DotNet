Console.WriteLine("Enter the five digit number:");
int Num=Convert.ToInt32(Console.ReadLine());

int sum = 0, rem;
while(Num>0)
{
    rem = Num % 10;
    sum =sum+ rem;
    Num = Num / 10;
}
Console.WriteLine("Sum of all digits: " + sum);