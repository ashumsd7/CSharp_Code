using System;
namespace Constructor_overloaded_this
{
    class Cons_over
    {   
        private int len,hei;
        private double wid;
        
        public Cons_over()
        {
            Console.WriteLine("Default_Constructor");
        }
        
           public Cons_over(int l,double w): this()
           {
               Console.WriteLine("parameterized Constructor is 2nd constructor");
               len=l;
               wid=w;
           }
           
           public Cons_over(int l,double w,int h): this(l,w)
           {
               Console.WriteLine("Parameterized Constructor in 3rd");
               hei=h;
               
           }
           
           public double volume()
           {
               return(len*wid*hei);
           }
           
           
        
        
    }
    
    class Geeks{
        public static void Main(string[] args)
        {
            Cons_over con=new Cons_over(10,20.5,30);
            
            Console.WriteLine("Volume is :{0}",con.volume());
        }
    }
}

