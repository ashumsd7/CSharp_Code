using System;
namespace variable_type{
    class Var{
        static void Main(String[] args)
        {
            var a=87;
            var b=76.55;
            var c="hello";
            
            Console.WriteLine("a is of type {0}",a.GetType());
            Console.WriteLine("b is of type {0}",b.GetType());
            Console.WriteLine("c is of type {0}",c.GetType());
            
            //  Console.WriteLine("size of a {0}",sizeof(var));
           // Console.WriteLine("b is of type {0}",b.GetType());
           // Console.WriteLine("c is of type {0}",c.GetType());
        }
    }
}

