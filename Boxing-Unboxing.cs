using System;

namespace Box{
	public class Boxing{
		public static void Main(string [] args){
			int a = 786;
			object o = a;  //Boxing
			a = 10;
			int b = (int)o;  //Unboxing
			Console.WriteLine("Value of a: " + a);
			Console.WriteLine("Value of o: " + o);
			Console.WriteLine("Value of b: " + b);

			//Convert String to int
			Console.WriteLine("Enter a Number: ");
			int x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("You entered: " + x);
			Console.ReadKey();
		}
	}
}