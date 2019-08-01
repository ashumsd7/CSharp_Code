using System;
class Anonyms_method
{
    // function or method declaratio like c before it defined the below line is about that
    public delegate void ABC(string pet);
    
    //main method
      public static void Main(string[] args)
      {
          
          //p is a type of pointer which will be used to call anonyms method  
          //and here we are defining a method anonyms method delegate which body is defined below and it is taking string parameter 
          ABC p= delegate(string mypet)
          {   
    Console.WriteLine("My Favorite pet is {0}",mypet);
           };
          //anonyms method is called
          p("dog");
    }
}

