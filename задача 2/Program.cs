Console.WriteLine("Введите первое число ");
string? firstnumber = Console.ReadLine() ;
int NumberA = Convert.ToInt32(firstnumber);
Console.WriteLine("Введите второе число ");
string? secondnumber = Console.ReadLine();
int NumberB = Convert.ToInt32(secondnumber);
int maxNumber;
if (NumberA > NumberB)
{
    maxNumber=NumberA;
} else {
    maxNumber=NumberB;
 } 
 Console.WriteLine(maxNumber);