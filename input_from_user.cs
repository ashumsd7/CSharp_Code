using System;

namespace DeclaringConstant
{
    public class CircleArea{
       public static void Main(string[] args)
        {
            const double pi=3.14159;
            double r;
            r=Convert.ToDouble(Console.ReadLine());
            double area=pi*r*r;
            Console.WriteLine("Radius={0}, area= {1}",r,area);
            Console.ReadLine();
            
        }
    }
}
