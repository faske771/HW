Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine());
int start = 1;
while (start<=A)
{
    if (start%2==0){
        System.Console.Write($"->{start}");
        start++;
    }
    else{
        start++;
    }
}