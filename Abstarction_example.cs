using System;
namespace Abstraction
{
    abstract class Shape{
        
        abstract public int area();
    }
    
    class Square :Shape
    {
        private int side;
        
        public Square (int x)
        {
            side = x;
        }
        
        
        public override int area()
        {
             Console.WriteLine("area of Square:");
            return (side*side);
        }
    }
    
    
    class Gfg
    {
        static void Main(string[] args)
        {
            Shape sh =new Square(4);
            double result=sh.area();
            
            Console.WriteLine("{0}",result);
        }
    }
}
