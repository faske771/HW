Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;
if (A>B){
    max = A;
    min = B;
}
else{
    max = B;
    min = A;
}
Console.WriteLine($"Максмальное - {max}, минимальное- {min}");