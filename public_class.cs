using System;
namespace RectangleOne
{
    class Rectangle{
        
        public double len;
        public double wid;
        
        public double GetArea()
        {
            return len*wid;
        }
        
        public void Display()
        {
            Console.WriteLine("Length is : {0}",len);
            Console.WriteLine("Width is : {0}",wid);
            Console.WriteLine("area is : {0}",GetArea());
            
        }
        
        
    }
    
    class MainClass
    {
        static void Main(String[] args)
        {
            Rectangle r= new Rectangle();
            r.len=3;
            r.wid=5;
            r.Display();
            Console.ReadLine();
            
           }
            
    }
}
