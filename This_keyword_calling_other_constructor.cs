using System;
namespace Constructors
{
    class Cons
    {
        public Cons(): this("geeks")
        {
            Console.WriteLine("Non parametric Constructor");
        }
        
        public Cons(string str)
        {
            Console.WriteLine("parametric Constructor called");
        }
    }
    
    
    class Driver
    {
        public static void Main(string[] str)
        {
            Cons c1= new Cons("ccc");
        }
    }
}

