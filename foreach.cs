using System;
namespace Loops
{
    class Foreach
    {
        public static void Main(string[] args)
        {
        int[] array=new int[] {1,2,3,4,5};
        
        foreach(int item in array)
        {
            Console.WriteLine(item);
        }
    }
    }
}
