//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
System.Console.WriteLine("Размер массива 1");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Размер массива 2");
int n = int.Parse(Console.ReadLine());
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next();
        }
    }
    return array;
}
int[] ReceivingCoordinates()
{
Console.WriteLine("Введите положение элемента");
int[] coordinates = new int[]{int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())};
return coordinates;
}
void CheckValue(int[,] array,int[] coordinates)
{
if (coordinates[0]<array.GetLength(0) && coordinates[1]<array.GetLength(1))
{
int value = array[coordinates[0],coordinates[1]];
System.Console.WriteLine(value);
}
else System.Console.WriteLine("Вне массива");

}
int[,] array = GetArray(m,n);
int[] coordinates = ReceivingCoordinates();
CheckValue(array,coordinates);