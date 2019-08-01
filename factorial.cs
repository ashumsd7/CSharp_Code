using System;
namespace Factorials{
    class Fact{
        
        public double CalculateFact(double num)
        {
            double result;
            if(num==1)
            return 1;
            else
            {
                result=num*(CalculateFact(num-1));
                return result;
            }
        }
        
        
        static void Main(String[] args)
        {
            Fact f= new Fact();
            Console.WriteLine("factorial of 5 is {0}",f.CalculateFact(5));
        }
            
        }
    }
