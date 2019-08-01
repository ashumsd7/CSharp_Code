using System;
namespace OuterInner
{
    class Outer
    {
        public void method1()
        {
            Console.WriteLine("Outer Class Method");
        }
        
        
        public class Inner
        {
            
            public void method2()
            {
                Console.WriteLine("Inner Class Method");
            }
        }
        
    }
    
    public class Check
    {
        static void Main()
        {
            
            Outer obj1= new Outer();
            obj1.method1();
            
            
            Outer.Inner obj2= new Outer.Inner();
            
            obj2.method2();
            
            
        }
    }
}

