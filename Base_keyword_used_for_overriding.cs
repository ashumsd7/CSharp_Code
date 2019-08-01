using System;
public class Web{
    
    string name = "geeksforgeeks";
    
    public virtual void showdata()
    {
        Console.WriteLine("Website name is "+ name);
    }
}


class stream : Web
{
    string s="computer science";
    
    public override void showdata()
    {
        base.showdata();
        Console.WriteLine("About"+s);
    }
}


class GFG
{
    public static void Main(string[] args)
    {
        stream E =new stream();
        
        E.showdata();
    }
    
}

