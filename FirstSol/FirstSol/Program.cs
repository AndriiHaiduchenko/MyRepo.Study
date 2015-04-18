using System;

namespace FirstSol
{
	class SupClass
	{
		public void Method()
		{
			Console.WriteLine ("Method belongs To SupClass");
		}
	}
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			SupClass instance = new SupClass ();
			instance.Method ();

			 Console.WriteLine ("Hello World!");

		}
	}
}
