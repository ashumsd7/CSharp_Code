using System;
namespace Structure
{
    public struct Person
    {
        public string Name;
        public int age;
        public int weight;
    }
    
    
    class Witty
    {
        static void Main(String [] args)
        {
            Person p1;
            
            p1.Name="Nishant";
            p1.age=22;
            p1.weight=90;
            
            Person p2;
            p2=p1; // copying
            
            Console.WriteLine("Data Stored In Structure is : Name {0} Age {1} Weight {2}",p1.Name,p1.age,p1.weight);
            
             Console.WriteLine("Data Stored In Structure is : Name {0} Age {1} Weight {2}",p2.Name,p2.age,p2.weight);
        }
    }
}

