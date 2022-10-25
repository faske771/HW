//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
System.Console.WriteLine("Размер массива 1");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Размер массива 2");
int n = int.Parse(Console.ReadLine());
double[,] GetArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 20);
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
       Console.WriteLine();
    } 
    
}
double[] AvarageColumn(double[,] array)
{
    double[] newarray = new double[array.GetLength(0)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
        sum = sum + array[i,j];
        }
        newarray[i] = sum / array.GetLength(0);
    }
    return newarray;
}
void OneDimensionalArrayPrint(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
           Console.Write($"{array[i]} ");
    } 
}
PrintArray(GetArray(m,n));
System.Console.WriteLine();
OneDimensionalArrayPrint(AvarageColumn(GetArray(m,n)));
