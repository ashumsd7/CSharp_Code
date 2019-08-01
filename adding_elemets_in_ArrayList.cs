

using System;
using System.Collections;
public class ArrayListImplement
{
     public static void Main(string[] args)
{
ArrayList mylist= new ArrayList();

mylist.Add(11);
mylist.Add(22);
mylist.Add(33);
mylist.Add(44);

foreach(int i in mylist)
Console.WriteLine(i);

///now we are going to ass element at the end of the arraylist


mylist.AddRange(mylist);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// here we have jjudst copied all elements of prev used list 

//look
foreach(int i in mylist)
Console.WriteLine(i);

string[] str = new  string[] {"hello" ,"wittybrains"};


mylist.AddRange(str);


 foreach(var i in mylist)
Console.WriteLine(i);
     }
}



