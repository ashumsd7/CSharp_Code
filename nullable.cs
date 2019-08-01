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
              
              Nullable<int> n3 =457;
               Console.WriteLine(n3.GetValueOrDefault());
        }
    }
}
