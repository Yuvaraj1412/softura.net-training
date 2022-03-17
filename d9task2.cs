using System;
public abstract class Calculator
{
public abstract void Addition(int n1,int n2);
public abstract void Sub(int n1,int n2);
public abstract void Mul(int n1,int n2);
public abstract void Div(int n1,int n2);
}
class Cal : Calculator
{
public override void Addition(int n1,int n2)
{
Console.WriteLine("add of nos:" +(n1+ n2));
}
public override void Sub (int n1,int n2) 
{
Console.WriteLine("sub of nos:" +(n1 - n2));
}
public override void Mul(int n1,int n2)
{
Console.WriteLine("mul of nos:" +(n1*n2));
}
public override void Div (int n1,int n2)
{
double res=(double)n1/n2;
Console.WriteLine("div of nos:"+res);
}
}
class t1
{
public static void Main()
{
Cal obj=new Cal();
obj.Addition(10,30);
obj.Sub (20,50);
obj.Mul (2,3);
obj.Div (20,5);
}
}



