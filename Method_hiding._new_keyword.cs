using System;
public class My_Family
{
    public void Member()
    {
Console.WriteLine("TOtal no of family mem i do not want to show");
}

}

public class My_Member : My_Family
{

/// we have used new keyword to redifine base method
public new void member()
{
    Console.WriteLine("I want to show it");
}
   }
   
class Driver
{
    public static void Main(string[] args)
    {
    My_Member obj=new My_Member();
        obj.member();
    
}
}

    