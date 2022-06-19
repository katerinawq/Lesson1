Console.WriteLine("Введите первое число"); 
int NumberN = int.Parse(Console.ReadLine()); 

Console.WriteLine("Введите второе число");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Число: " + numberM);
Console.WriteLine("Квадрат числа: " + numberM * numberM);

if (NumberN == numberM * numberM)
{
    Console.WriteLine("УРА, первое число является квадратом второго!");
    }
    
else 
{
Console.WriteLine("Первое число не является квадратом второго!");
}