using System;
using FirstSpace;
using FirstSpace.SecondSpace;

namespace FirstSpace{
	public class First{
		public void show(){
			Console.WriteLine("First");
		}
	}
}
namespace FirstSpace.SecondSpace{
	public class Second{
		public void show(){
			Console.WriteLine("Second");
		}
	}
}
public class Test{
	public static void Main(string [] args){
		First x = new First();
		Second y = new Second();
		x.show();
		y.show();
		Console.ReadKey();
	}
}