using System;


class Example 
{
private string str;

public void setdata(string s)
{
str=s;
}

public void Display()
{
Console.WriteLine("Strig is "+ str);
}

public Example Astr(Example ex)
{
Example obj= new Example();


obj.str= str+ex.str;
return obj;
}

}

public class Test
{
public static void Main(string[] args)
{
Example o1=new Example();
Example o2= new Example();

o1.setdata("My name is");
o2.setdata("khan");

Example o3=o1.Astr(o2);
o1.Display();
o2.Display();
o3.Display();
}
}

