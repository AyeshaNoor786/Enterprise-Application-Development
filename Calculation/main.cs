using System;
namespace Task{
	public class main{
		public static void Main(string [] args){
			Console.WriteLine("Ayesha Noor");
			Console.WriteLine("SE");
			Console.WriteLine("BSEF19M536");
			int a=15;
			int b=3;
			
			Console.Write("Addition:");
			Console.WriteLine(Addition.addition(a,b));
			
			Console.Write("Subtraction:");
			Console.WriteLine(Subtraction.subtract(a,b));
			
			Console.Write("Multiplication:");
			Console.WriteLine(Multiplication.multiply(a,b));
			
			Console.Write("Division:");
			Console.WriteLine(Division.divide(a,b));
			
			Console.Write("Mod:");
			Console.WriteLine(Mod.mod(a,b));
			
			Console.ReadKey();
		}
	}
}