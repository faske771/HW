System.Console.WriteLine("Длинна массива");
int[] createnewarray(int size)
{
    int[] ints = new int[size];
    Random random = new Random();
    for (int i = 0; i < ints.Length; i++) {ints[i]=random.Next();}
    return ints;
}
string arrayasstring(int[] ints)
{
string result = string.Empty;
System.Console.Write("[ ");
for (int i = 0; i<ints.Length; i++) { 
    result = result + $"{ ints[i]}, ";
}
result = result + $"]";
return result;
}
int numbers(int[] ints)
{
    int count = 0;
    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i]%2==0) count++;
    }
    return count;
}
int[] ints  = createnewarray(int.Parse(Console.ReadLine()));
System.Console.WriteLine(arrayasstring(ints));
System.Console.WriteLine(numbers(ints));