using System;
namespace Static_Test
{
    class StaticClass
    {
        static StaticClass()
        {
            Console.WriteLine("hello this is static constructor");
        }
        
        public StaticClass(int n)
        {
            Console.WriteLine("instance Constructor : {0}",n);
        }
        
        public static void Main(String[] args)
        {
            StaticClass s1=new StaticClass(5);
        }
        
    }
    
    
}
