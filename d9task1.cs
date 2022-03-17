using System;
interface Membership
{
void Platinum();
void Gold();
void Silver();
}
class Package:Membership
{
public void Platinum()
{
Console.WriteLine("7 days accommodation at resort,"+"5 dinners on the house");
}
public void Gold()
{
Console.WriteLine("5 days accommodation at resort,"+"2 dinners on the house");
}
public void Silver()
{
Console.WriteLine("3 days accommodation at resort");
}
}
class infImple
{
public static void Main()
{
Package pac=new Package();
pac.Platinum();
pac.Gold();
pac.Silver();
}
}
