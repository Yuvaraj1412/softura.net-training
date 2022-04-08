using System;
using System.Collections.Generic;
using System.Text;

namespace linq
{
    class day25task
    {
		static int countGoat(int eyes,int Legs)
		{
			int count = 0;
			count = (Legs) - (eyes - 1);
			count = count / 2;
			return count;
		}
		public static void Main()
		{
			int eyes = 52, Legs = 80;
			int Goat = countGoat(eyes, Legs);
			Console.WriteLine("Goat = " + Goat);
			Console.WriteLine("Ducks = " + (Goat - 2));
		}
	}
}

