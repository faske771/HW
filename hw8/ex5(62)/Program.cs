// Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] GetSpiralArray()
{
    System.Console.WriteLine("Количество элементов массива в строке/столбце : ");
    int m = int.Parse(Console.ReadLine());
    int[,] array = new int[m, m];
    int spiralnumber = 1;
    int i = 0;
    int j =0;
    while (m != 0) {
            int n = 0;
            do {array[i, j++] = spiralnumber++;} while (++n < m - 1);
            for (n = 0; n < m - 1; n++) array[i++, j] = spiralnumber++;
            for (n = 0; n < m - 1; n++) array[i, j--] = spiralnumber++;
            for (n = 0; n < m - 1; n++) array[i--, j] = spiralnumber++;
            ++i; ++j;
            if (m<2) m = 0;
            else m = m-2;
            }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10) System.Console.Write($"  {array[i,j]} ");
            else if (array[i,j] < 100) System.Console.Write($" {array[i,j]} ");
            else Console.Write($"{array[i,j]} ");
            
        }
       Console.WriteLine();
    } 
    
}
PrintArray(GetSpiralArray());