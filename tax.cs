using System;
class T1
{
public virtual void tax( int price)
{
int vat;
vat=(int)(price*(1+0.2));
Console.WriteLine("Vat:"+vat);
}
}
class T2:T1
{
public override void tax(int price)
{
int gst;
gst=(int)(price*12)/(100);
Console.WriteLine("Gst:"+gst);
}
}
class Tax
{
public static void Main()
{
int amount;
Console.WriteLine("Enter the amount:");
amount=Convert.ToInt32(Console.ReadLine());
T2 obj=new T2();
obj.tax(amount);
T1 obj1=new T1();
obj1.tax(amount);
}
}

