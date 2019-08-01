using System;
namespace InheritenceEx
{
    class Papa
    {
        public int a;
        public string name;
        
        public void Entry(string str, int rupees)
        {
            this.name=str;
            this.a=rupees;
        }
        
        public void display()
        {
            Console.WriteLine(name);
            Console.WriteLine(a);

        }
        
        
    }
    class Beta : Papa
    {
        public static void Main(String[] args)
        {
            
            //we are making refrence variable of class Beta and accessing method of class papa because clss beta is sub class and class papa is inheritedc by class beta
         Beta b1=new Beta();
        b1.Entry("mohan",10);
        b1.display();
        }
    }
    
}

