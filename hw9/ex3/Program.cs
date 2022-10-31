System.Console.WriteLine("M");
int M = int.Parse(Console.ReadLine());
System.Console.WriteLine("N");
int N = int.Parse(Console.ReadLine());
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n ==0) return Akkerman(m - 1,1);
    return Akkerman(m - 1, Akkerman(m , n - 1));
}
if (M < 0 || N < 0) System.Console.WriteLine("M & N => 0 ");
else System.Console.WriteLine(Akkerman(M,N));


