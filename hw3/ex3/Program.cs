System.Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
/*int[] array = new int[N];
for (int i=1;i<N;i++)
{
    array[i]=i+1;
}*/
int[] newarray = new int[N];
for (int j=0;j<N;j++)
{
    double cube = Math.Pow(j+1, 3);
    int intcube = (int)cube; 
    newarray[j] = intcube;

}
var arr = string.Join(" ", newarray);
Console.WriteLine(arr);
