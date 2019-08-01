using System;
namespace Encapulations{
    
    class Encap{
        
        private int balance;
        private string name;
        
        
        public int SetBal
        {
            get
            {
                return balance;
            }
            
            set
            {
                balance=value;
            }
            
        }
        
        public string SetName
        {
            get
            {
                return name;
            }
            
            set
            {
                name=value;
            }
        }
    }
    
    
    class Access
    {
        static void Main(String[] args)
        {
            Encap acc= new Encap();
            // accessing members private using accessors get/ and set properties 
            acc.SetName="Abhishek";
            acc.SetBal=100;
            
            
            Console.WriteLine("Welcome to the KK Bank");
            Console.WriteLine(acc.SetName);
        }
    }
}

