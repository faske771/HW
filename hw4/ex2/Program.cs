Console.WriteLine("Введите число");
System.Console.WriteLine(Sum(Console.ReadLine()));
int Sum(string array)
{
int result = 0;
for (int i = 0; i < array.Length;i++)
{
    result += int.Parse(array[i].ToString());
}
return result;
}