using System;
namespace Witty{
    class Control{
        static void Main(String[] args)
        {
            int[] array =new int[10];
            int i,j;
            
            for(i=0;i<10;++i)
            {
                array[i]=100+i;
            }
            for(j=0;j<10;++j)
            {
                Console.WriteLine("Array[{0}] has {1}",j,array[j]);
            }
        }
    }
}
