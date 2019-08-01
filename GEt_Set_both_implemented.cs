using System;
namespace GetSetGo
{
    class Student
    {
        private string name= "WittyBrains";
        
        public string Name
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
    
     class TestStudent
    {
        public static void Main(string [] args)
        {
            Student s=new Student();
            s.Name="Only Witty Brains";
            
            Console.WriteLine("Name is  "+ s.Name);
        }
    }
   
}

