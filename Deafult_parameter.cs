using System;
class Default_Parameters
{
    static public void ABC(string fname, string lname ,int age=20, string branch="CSE")  
    {
        
        Console.WriteLine("First Name : {0}",fname);
        Console.WriteLine("Last Name : {0}",lname);
         Console.WriteLine("age: {0}",age);
        Console.WriteLine("Branch : {0}",branch);
    }
    
    public static  void Main(string[] args)
    {
        ABC("ankita", "saini");
         ABC("Sita", "Tiwari");
         ABC("dimple", "Daini", 15);
        
    }
}

