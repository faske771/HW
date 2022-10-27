//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
System.Console.WriteLine("Размер массива 1");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Размер массива 2");
int n = int.Parse(Console.ReadLine());
int [,] array = GetArray(m, n);
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
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
int[,] NewArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int k = 1; k < array.GetLength(1); k++)
            
            {
                if (array[j, k-1] < array[j, k])
                 {
                    int temp = array[j, k-1];
                    array[j, k-1] = array[j, k];
                    array[j,k] = temp;
                 }
            }
        }

    }
    return array;
}
void PrintArray(int[,] array)
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
PrintArray(array);
System.Console.WriteLine();
PrintArray(NewArray(array));