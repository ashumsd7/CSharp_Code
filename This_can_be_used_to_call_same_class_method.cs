using System;
namespace Constructors
{
    class ThisUse3
    {
        
        public void Xyz()
        {
            this.Abc();
            Console.WriteLine("Witty");
        }
        public void Abc()
        {
            Console.WriteLine("hello");
        }
       
    }
    
    class Driver
    {
        public static void Main(string[] args)
        {
            ThisUse3 t1=new ThisUse3();
            
            t1.Xyz();
        }
    }
}

