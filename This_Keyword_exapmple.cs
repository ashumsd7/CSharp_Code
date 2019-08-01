using System;
namespace Thiss
{
    class This
    {
        public int num;
       public  string str;
        
        public void SetV(int n, string s)
        {
            this.num=n;
            this.str=s;
        }
        
    }
    
    
    
    class ThisNew
    {
        public static void Main(string[] args)
        {
        
        This s1= new This();
        
        s1.SetV(14,"helloWitty");
        Console.WriteLine(s1.num);
        Console.WriteLine(s1.str);
        }
    } 
}

