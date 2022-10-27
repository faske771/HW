// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] GetArray()
{
    System.Console.WriteLine("Количество элементов массива в строке/столбце : ");
    int m = int.Parse(Console.ReadLine());
    int[,] array = new int[m, m];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 5);
        }
    }
    return array;
}
int[,] array = GetArray();
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
void GetLineNumber(int[,] array)
{
    int[] sums = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[i,j];
            sums[i] = sum; 
        }
    }
    int min = sums[0];
    int linenumber = 0;
    for (int i = 0;i<sums.Length; i++)
    {
        if (sums[i] < min)
        {
            min = sums[i];
            linenumber = i;
        }
    }
    System.Console.WriteLine($"Номер строки с минимальной суммой значений: {linenumber+1} ");

}
GetLineNumber(array);