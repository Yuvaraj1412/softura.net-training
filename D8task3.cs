using System;
class userlogin
{
public void login(String n1,String n2)
{
Console.WriteLine("Email.Id- "+n1+"&"+"password-"+n2);
}
public void login(int n3,int n4)
{
Console.WriteLine("membership Id-"+n3+" &"+" pin-"+n4);
}
public void login(string n5,int n6)
{
Console.WriteLine("mobile number-"+n5+"&"+"pin-"+n6);
}
public static void Main()
{
userlogin obj=new userlogin();
obj.login("abc@gmail.com","1234");
obj.login(4342,9876);
obj.login("9876543210",5643);
}
}
