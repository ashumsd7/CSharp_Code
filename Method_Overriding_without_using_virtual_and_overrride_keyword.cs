using System;
public class Base
{

public  void Show()
{
Console.WriteLine("Base Class Method");
}
 
 
}
 
public class Derived : Base
 {
public  void Show()
{
Console.WriteLine("Derived Class Method");
}

 
 }
public class Drive
{
public static void Main(string[] args)
{

Base obj= new Base();
obj.Show();
             
             Base obj2 =new Derived();
             obj2.Show();

}
}

 
