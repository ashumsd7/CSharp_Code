using System;

namespace ArrayObjects
{
    class Circle
    {
        public int rad;
        public Circle()
        {
            rad=0;
        }
        
        public void setValue(int r)
    {
        this.rad=r;
    }
    
    public double Area()
    {
        double result;
        result= 3.14*rad*rad;
        return rad;
    }
    
    
    }
    
   public class program
    {
       public static void Main(string[] args)
        {
            Circle[] circleArray =new Circle[2];
            
            circleArray[0]= new Circle();
            circleArray[1] = new Circle();
            
            circleArray[0].setValue(1);
            circleArray[1].setValue(2);
            
            for(int i=0;i<circleArray.Length;++i)
            {
                Console.Write("Area of circle with radius " + (i + 1)); 
            Console.Write(" is " + circleArray[i].Area() + "\n"); 
                
            }
        }
    }
}

