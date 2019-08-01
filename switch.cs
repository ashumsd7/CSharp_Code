using System;
namespace SwitchStatements
{
    
    class Switch
    {
        public static void Main(String[] args)
        {
        int item=2;
        switch(item)
        {
            case 1: 
            Console.WriteLine("hello 1");
            break;
            
            case 2: 
            Console.WriteLine("hello 2");
            break;
            
            case 3: 
            Console.WriteLine("hello 3");
            break;
            
           default:
            Console.WriteLine("not matched");
            break;
        }
        }
    }
}

