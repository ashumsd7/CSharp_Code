using System;
class Geeks
    {
        private string month;
        private int year;
        
        public Geeks(Geeks s)
        {
            month=s.month;
            year=s.year;
        }
    
     public Geeks(string month, int year) 
    { 
        this.month = month; 
        this.year = year; 
    } 
  
        
        public string Details
        {
            get
            {
                return month;
            }
        }
        
        public static void Main(string[] args)
        {
            Geeks g1= new Geeks("june", 2018);
            Geeks g2= new Geeks(g1);
            Console.WriteLine("month is {0}",g2.month);
        }
    }

