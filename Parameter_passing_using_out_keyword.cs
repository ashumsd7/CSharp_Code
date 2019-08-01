using System;


public class OUT_PARAMETER
{

public static void Main(String[] args)
{
//num is not initilized
int num;

AddNum(out num);

Console.WriteLine("the sum is {0}",num);
}

public static void AddNum(out int num)
{
num=40;
num=num*num;

//here we are not writing anything like we are returning
//number is changed actually
}

}

