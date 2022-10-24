int[] createnewarray()
{
    int[] ints = new int[8];
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
int[] ints  = createnewarray();
System.Console.Write(arrayasstring(ints));