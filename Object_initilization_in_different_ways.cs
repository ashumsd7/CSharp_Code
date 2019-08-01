using System;
namespace ObjectInitilizer
{
class ObjectIn
{
public string author_name
{
get;
set;
}
public int author_id
{
get;
set;
}
public int total_article
{
get;
set;
}

}

public class Driver
{

public static void Main(string[] args)
{
ObjectIn obj =new ObjectIn() {

author_name= "ankita patel",
author_id = 111,
total_article= 134



};
Console.WriteLine("author Name {0}",obj.author_name);
Console.WriteLine("Author_Id {0}",obj.author_id);
Console.WriteLine("Total no of articles : {0}",obj.total_article);

     	}
}
}

