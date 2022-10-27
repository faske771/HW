int[,] createnewarray()
{
    System.Console.WriteLine("Размеры матрицы");
    
    int[,] ints = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];
    for (int i = 0; i< ints.GetLength(0); i++){
    for (int j = 0; j < ints.GetLength(1); j++) {
        System.Console.WriteLine($"Введите {j+1} элемент столбца  матрицы, строки {i+1}");
        ints[i,j]=int.Parse(Console.ReadLine());
        }}
    return ints;
}
int[,] array = createnewarray();
int[,] array2 = createnewarray();
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
PrintArray(array2);
int[,] matrixxmatsix(int[,] array, int [,] array2)
{
    int[,] newarray =new int[array.GetLength(0),array2.GetLength(1)];
    if (array.GetLength(1)!= array2.GetLength(0)) System.Console.WriteLine("Умножение матриц невозможно");
    else 
    {
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++)
    {
            for(int k = 0; k < array.GetLength(0); k++)
            {
                newarray[i,j] += array[i,k] * array2[k,j];
            }
    }
    }
    }
    return newarray;
}
System.Console.WriteLine();
int[,] newarray =  matrixxmatsix(array,array2);
PrintArray(newarray);
