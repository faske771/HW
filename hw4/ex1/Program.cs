int Pow(int a, int b){
int result = a;
for (int i = 1; i < b; i++)
{
    result = result * a;
}
return result;
}
System.Console.WriteLine(Pow(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())));