
using System;
public class Array_check
{
public static void Main(string[] args)
{
int[,] arr = new int[,] { {1,2},
{3,4},
{5,6}};
Console.WriteLine(arr.Equals(arr));

}

}