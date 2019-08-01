



using System;
namespace Swaping
{
    class Swap{
        public void SwapNumbers(ref int x, ref int y)
        {
            int temp;
            temp=x;
            x=y;
            y=temp;
        }
        
        static void Main(string[] args)
        {
            Swap sw=new Swap();
            int n1=100;
            int n2=200;
            Console.WriteLine("Before Swapping a={0} b= {1}",n1,n2);
            sw.SwapNumbers(ref n1,ref n2);
            Console.WriteLine("After Swapping a={0} b={1}",n1,n2);
            Console.ReadLine();
        }
    }
}

