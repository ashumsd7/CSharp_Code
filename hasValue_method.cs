using System;
namespace NullablePractice{
    
    class Nullable{
        
        static void Main(String [] args)
        {
            Nullable<int> n=null;
            Console.WriteLine(n.GetValueOrDefault());
            
            int? n1=null;
             Console.WriteLine(n1.GetValueOrDefault());
             
             int? n2=47;
              Console.WriteLine(n2.GetValueOrDefault());
              
              Console.WriteLine(n.HasValue);
              Console.WriteLine(n1.HasValue);
              Console.WriteLine(n2.HasValue);
              
        }
    }
}
