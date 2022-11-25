Console.WriteLine("Введите первое число ");
string? firstnumber = Console.ReadLine() ;
int NumberA = Convert.ToInt32(firstnumber);
Console.WriteLine("Введите второе число ");
string? secondnumber = Console.ReadLine();
int NumberB = Convert.ToInt32(secondnumber);
Console.WriteLine("введите третье");
string? thirdnumber = Console.ReadLine();
int NumberC = Convert.ToInt32(thirdnumber);
int maxNumber;
if (NumberB > NumberA)
{
     maxNumber = NumberB;
} else maxNumber = NumberA;
if (NumberC > maxNumber)
 {
    maxNumber=NumberC;
 } else maxNumber = maxNumber;

 Console.WriteLine(maxNumber);