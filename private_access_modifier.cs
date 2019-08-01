using System;
namespace RectangleOne
{
    class Rectangle{
        
        private double len;
        private double wid;
        
        
        public void SetValues()
        {
            
            len=5;
            wid=6;
            
        }
        
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
           // r.len=3;
           // r.wid=5;
            r.SetValues();
            r.Display();
            Console.ReadLine();
            
           }
            
    }
}

