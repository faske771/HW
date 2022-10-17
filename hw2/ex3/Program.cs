Console.WriteLine("Введите число от 1 до 7");
int N = int.Parse(Console.ReadLine());
if (N<=7 && N>0)
{
switch (N)
{
    case 1: System.Console.WriteLine("Рабочий день");
    break;
    case 2: System.Console.WriteLine("Рабочий день");
    break;
    case 3: System.Console.WriteLine("Рабочий день");
    break;
    case 4: System.Console.WriteLine("Рабочий день");
    break;
    case 5: System.Console.WriteLine("Рабочий день");
    break;
    case 6: System.Console.WriteLine("Выходной");
    break;
    case 7: System.Console.WriteLine("Выходной");
    break;
}
}
else
{
    System.Console.WriteLine("от 1 до 7");
}