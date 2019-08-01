using System;
namespace General
{

public class Table{

public int TablePrint(int num)
{
   int i;
   for(i=1;i<=10;++i)
   {
       Console.WriteLine("{0}*{1} =  {2}",num,i,num*i);
   }
   return 0;
}

}

class Tabble11{
   
   public static void Main(String[] args)
   {
       
   
   Table t1=new Table();
   t1.TablePrint(5);
   }
}
}

