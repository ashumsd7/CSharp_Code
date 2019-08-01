


using System;
namespace RectangleApplication
{
    class Rectangle{
        double length;
        double width;
        
        public void AcceptDetails()
        {
            length=3.2;
            width=1.2;
        }
        public double GetArea(){
            return length*width;
        }
        
        public void Display()
        {
            Console.WriteLine("Length: {0}",length);
            Console.WriteLine("Width: {0}",width);
            Console.WriteLine("Width: {0}",GetArea());
        }
    }
    
    class ExecuteRectangle
    {
        static void Main(String[] args)
        {
            Rectangle r=new Rectangle();
            r.AcceptDetails();
            r.Display();
            Console.ReadLine();
        }
    }
    
}