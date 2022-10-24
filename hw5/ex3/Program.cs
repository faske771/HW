System.Console.WriteLine("Длинна массива");
double[] createnewarray(int size)
{
    double[] ints = new double[size];
    Random random = new Random();
    for (int i = 0; i < ints.Length; i++) {ints[i]=random.Next(1,100);}
    return ints;
}
string arrayasstring(double[] ints)
{
string result = string.Empty;
System.Console.Write("[ ");
for (int i = 0; i<ints.Length; i++) { 
    result = result + $"{ ints[i]}, ";
}
result = result + $"]";
return result;
}
double maxmin(double[] ints)
{
double max = ints[0];
double min = ints[0];
for (int i = 0; i < ints.Length; i++)
{
    if (max < ints[i]) max =ints[i];
    if (min > ints[i]) min = ints[i];
}
double diff = max - min;
/*string max1 = Convert.ToString(max);
string min1 = Convert.ToString(min);
System.Console.WriteLine(max1);
System.Console.WriteLine(min1);*/
return diff;
}

double[] ints  = createnewarray(int.Parse(Console.ReadLine()));
System.Console.WriteLine(arrayasstring(ints));
System.Console.Write("Разница между максимальным и минимальным элементом: ");
System.Console.Write(maxmin(ints));
