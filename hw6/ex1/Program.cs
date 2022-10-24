int[] createnewarray(int M)
{
    int[] ints = new int[M];
    for (int i = 0; i < ints.Length; i++) {
        System.Console.WriteLine($"Введите {i+1} элемент массива");
        ints[i]=int.Parse(Console.ReadLine());
        }
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
void afternull(int[] ints)
{
    int count = 0;
    for (int i = 0; i<ints.Length; i++)
    {
        if (ints[i]>0) count++;
    }
    System.Console.WriteLine($"Значений элементов больше 0 : {count} ");
}
int[] ints = createnewarray(int.Parse(Console.ReadLine()));
System.Console.WriteLine(arrayasstring(ints));
afternull(ints);