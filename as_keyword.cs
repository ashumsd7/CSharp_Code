using System;
using System.Text;
using System.Collections.Generic;
namespace New
{
    
class Gfg{
    
    public static void Main(String[] args)
    {
        string str1="Witty";
        object obj1= str1;
        string str2=obj1 as string;
        
        if(str1!=null)
        {
            Console.WriteLine("successfully casted ");
        }
    }
}
}

