
void eq()
{
System.Console.WriteLine("Введите k1");
double k1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите k2");
double k2 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите b2");
double b2 = double.Parse(Console.ReadLine());
System.Console.WriteLine($"y = {k1}x + {b1}");
System.Console.WriteLine($"y = {k2}x + {b2}");
if ((k1 == k2) && (b1 == b2)) {
System.Console.WriteLine("Прямые лежат друг на друге");}
else if (k1==k2) {
System.Console.WriteLine("Прямые параллельны");}
else
{
double x=(b2-b1)/(k1-k2);
double y=(k1*(b2-b1))/(k1-k2)+b1;
System.Console.WriteLine($"х = {x}; y = {y}");
}
}
eq();
