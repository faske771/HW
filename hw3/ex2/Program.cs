﻿System.Console.WriteLine("ВВедите x точки 1");
int x1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("ВВедите y точки 1");
int y1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("ВВедите z точки 1");
int z1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("ВВедите x точки 2");
int x2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("ВВедите y точки 2");
int y2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("ВВедите z точки 2");
int z2 = int.Parse(Console.ReadLine());
int[,,] array = new int[2,2,2];
array[0,0,0] = x1;
array[0,1,0] = y1;
array[0,0,1] = z1;
array[1,0,0] = x1;
array[1,1,0] = x2;
array[1,1,1] = z2;
double r = Math.Sqrt(Math.Pow((array[0,0,0] - array[1,0,0]),2)+ Math.Pow((array[0, 1, 0] - array[1, 1, 0]),2) + Math.Pow((array[0,0,1]-array[1,1,1]),2));
System.Console.WriteLine(r);