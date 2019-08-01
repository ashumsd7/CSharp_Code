using System;
namespace DynamicBinding{
    class DynamicB{
        static void Main(String[] args)
        {
        
        dynamic obj=4;
        dynamic obj1=5.78;
        
        Console.WriteLine("the type of objects are:");
        Console.WriteLine(obj.GetType());
        Console.WriteLine(obj1.GetType());
        }
    }
}

