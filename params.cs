using System;
namespace Paramss{
    class Params{
        
        public static int add(params int[] List)
        {
            int sum=0;
            foreach(int i in List)
            {
                sum=sum+i;
            }
            return sum;
        }
        
        public static void Main(String[] args)
        {
            int total=add(11,11,11,11,11);
            Console.WriteLine("total is {0}",total);
            
        }
    }
    
    
    
}
