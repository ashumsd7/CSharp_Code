using System;
namespace Constructor_Overloading
{   
    class Add
    {
    
    int x,y;
    double f;
    string s;
    
    //First Constructor
        public Add(int a, double b)
        {
            x=a;
            f=b;
        }
        
        //2nd constructor
        
        public Add(int a,string b)
        {
            y=a;
            s=b;
            
        }
        
        public void show()
        {
            Console.WriteLine("1st Constructor (int+float) = {0}",(x+f));
            
        }
        
        public void show1()
        {
            Console.WriteLine("2nd constructor (int+ string) = {0}",(s+y));
        }
        
        
    }
    
    class Driver
    {
        
        public static void Main(string[] args)
        {
        Add g= new Add(10, 20.2);
        g.show();
        
        Add h= new Add(20, "WittyBrains are Here");
        h.show1();
        
        }
        
    }
    
    
}

