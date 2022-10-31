long[,] PascalTrianqle() 
{
    long n = long.Parse(Console.ReadLine());
    long [,] array = new long [n,n];
    int k = 1;
    for (int i=0;i<n;i++)
    { 
        for (int j=0;j<k;j++)
        {
           array[i,j] = C(i,j);
        }
        k++;
    }
    return array;
    
}
void PrintArray(long[,] array)
{
    int k = Convert.ToInt32(array.GetLength(0));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int p = 0; p<k;p++)
        {
            System.Console.Write(" ");
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            if (array[i,j] !=0) 
            {
            Console.Write($"{array[i,j]} ");
            }

        }
       k--;
       Console.WriteLine();
    } 
    
}
long fact(long number)
{
    int val = 1;
    for(int i = 2; i < number;i++ )
    {
        val *= i;
    }
    return val;
}
long C(int n, int k)
{
    return fact(n)/(fact(k)*fact(n-k));
}
//Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "123"));
PrintArray(PascalTrianqle());

