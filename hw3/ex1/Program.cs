Console.WriteLine("Введите пятизначное число");
string array = System.Console.ReadLine();
int n = array.Length;
int n2 = n;
int b = 0;
for (int i = 0; i <= n/2; i++)
{
    if (n == 5) { 
    if(array[i] != array[n2-1])
    {
        break;
    }
    else{
        n2 = n2 - 1;
        b = 1;
    }
    }
    else {
       Console.WriteLine("Введите пятизначное число");
       break;
    }
} 
if (b==1) System.Console.WriteLine($"Число {array} является палиндромом");
else System.Console.WriteLine($"Число {array} не является палиндромом");

