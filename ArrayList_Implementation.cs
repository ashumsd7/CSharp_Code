using System;
using System.Collections;
public class Array_List
{

public static void Main(string[] args)
{
ArrayList mylist= new ArrayList();
mylist.Add(23);
mylist.Add("hello");
mylist.Add(565.88);
mylist.Add('g');


foreach(var ele in mylist)
{

Console.WriteLine(ele);
}
}
}
