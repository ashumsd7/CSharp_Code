using System;
    namespace Boxing{
        class BoxingClass{
            
            static void Main(String[] args)
            {
                int num= 200;
                Object obj= num; //boxing
                obj=900;
                num=500;
                Console.WriteLine("value of num is {0}",num);
                Console.WriteLine("Value of obj is {0}",obj);
            }
        }
    }