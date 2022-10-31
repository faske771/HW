System.Console.WriteLine("M");
int M = int.Parse(Console.ReadLine());
System.Console.WriteLine("N");
int N = int.Parse(Console.ReadLine());
int max = M;
int min = N;
if (M<N) 
    {
        max = N;
        min = M;
    }
int SumMtoN(int max, int min)
{
    if (max<=min) return min;
    else return min + SumMtoN(max, min+1);
}
System.Console.WriteLine(SumMtoN(max,min));