using System;
namespace Calculator{
    class NumberManipulator
    {
        public int FindMax(int num1,int num2)
        {
            int result;
            result= (num1>num2)? num1:num2;
            return result;
            
        }
    }
    
    
    class Test
    {
        static void Main(String[] args)
        {
            int x=100;
            int y=101;
            NumberManipulator n= new NumberManipulator();
            int result;
            result=n.FindMax(x,y);
            Console.WriteLine("maximum value in {0} and {1} is {2}",x ,y,result);
            Console.ReadLine();
        }
    }
}

