using System;
class Geeks{
    
    public delegate void addnum(int a, int b);
    public delegate void subnum(int a, int b);
    
    public void sum(int a,int b)
    {
        
        Console.WriteLine("Sum is {0}",a+b);
    }
    
    public void subtract(int a, int b)
    {
         Console.WriteLine("Subtraction is {0}",a-b);
    }

public static void Main(string[] args)
{
    Geeks obj = new Geeks();
    
    addnum del_obj1 = new addnum(obj.sum);
    addnum del_obj2 = new addnum(obj.subtract);
    
    del_obj1(100,40);
    del_obj2(100,99);
}
}

