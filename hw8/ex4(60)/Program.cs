//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
System.Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите k");
int k = int.Parse(Console.ReadLine());
int[,,] array = GetArray(m,n,k);
int[,,] GetArray(int m, int n, int k)
{
    int[,,] array = new int[m, n, k];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                array[i, j, l] = rnd.Next(1, 20);
            }
        }
    }
    return array;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
            Console.Write($"{array[i,j,l]} ");
            }
        }
       Console.WriteLine();
    } 
    
}
void ElementPosition(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                System.Console.Write($"{array[i, j, l]} : ({i},{j},{l}) ; ");
            }
        }
    }
}
PrintArray(array);
System.Console.WriteLine();
ElementPosition(array);
