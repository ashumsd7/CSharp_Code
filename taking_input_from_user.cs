using System;
namespace hello
{
    public class HelloOne
    {
       public  static void Main(String[] args)
        {
            int a;
            double b;
            Console.WriteLine("Enter An Integer Value");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value of a is {0}",a);
            
             Console.WriteLine("Enter An Float Value");
            b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Value of b is {0}",b);
        }
    }
}
