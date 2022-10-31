System.Console.WriteLine("N : ");
int n = int.Parse(Console.ReadLine());
int numbers(int n)
{
    System.Console.Write(" " + n);
    if (n<=1) return 1;
    else return n + numbers(n-1);
}
numbers(n);