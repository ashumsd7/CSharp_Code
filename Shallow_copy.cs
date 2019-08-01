using System;
namespace Hello
{
    class ShallowCopy : ICloneable
    {
        public int I {get; set;}
        public int J {get; set;}
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    
    
    class Demo
    {
        public static void Main()
        {
            ShallowCopy obj =new ShallowCopy();
            Console.WriteLine("before Shallow copy");
            ShallowCopy objClone=obj;
            obj.I=10;
            Console.WriteLine(" objValue={0} clone Value= {1}",obj.I,objClone.I=10 );
            
            Console.WriteLine("After Shallowing -----");
            ShallowCopy objClone2= (ShallowCopy)obj.Clone();
            obj.I=1000;
            
            Console.WriteLine("after using MemberwiseClone() and Clone() method {0}",objClone2.I);
        }
    }
}

