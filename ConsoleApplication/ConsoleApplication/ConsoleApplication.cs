using System;

 class ConsoleApp
{  
	 public static void Main()
	{
		string k = "kate";
		string va = "virginia";

		DateTime today = DateTime.Today;

		DateTime daysLeft = DateTime.Parse("12/25/2020");

		//Calculate countdown timer.
		TimeSpan t = daysLeft - today;

		Console.WriteLine("My name is {k}.");
		Console.WriteLine("I am from {va}.");
		Console.WriteLine("Today is" + today.ToString("MM/dd/yyyy"));
		Console.WriteLine("There are " + t + " days until Christmas");

		Console.ReadKey();
	}
}
