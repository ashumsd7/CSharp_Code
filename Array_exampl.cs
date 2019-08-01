using System;
public class Array1
{
    public static void Main(string[] args)
    {
    int[] arr= new int[5];
    Console.WriteLine("Enter 5 elements in array:");
    for(int i=0;i<5;i++)
    {
        Console.WriteLine("Enter element at position arr{0}",i+1);
        arr[i]=Convert.ToInt32(Console.ReadLine());
    }
    
    for(int i=0;i<5;i++)
    {
        Console.WriteLine("array {0} has {1} value",i+1,arr[i]);
    }
        }
}
