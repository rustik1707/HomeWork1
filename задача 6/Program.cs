Console.WriteLine("введите число");
string?number = Console.ReadLine() ;
int NumberA = Convert.ToInt32(number);

if (NumberA%2 == 0)
{ 
    Console.WriteLine("четное число");
} else { 
    Console.WriteLine("нечетное число");
} 