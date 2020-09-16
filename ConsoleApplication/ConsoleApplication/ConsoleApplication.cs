using System;

public class ConsoleApp
{  
	 static void Main()
	{
		string k = "kate";
		string va = "virginia";

		DateTime today = DateTime.Today;

		DateTime daysLeft = DateTime.Parse("12/25/2020");

		//Calculate countdown timer.
		TimeSpan t = daysLeft - today;

		Console.WriteLine("My name is {0}.");
		Console.WriteLine("I am from {1}.");
		Console.WriteLine("Today is" + today.ToString("dd/MM/yyyy"));
		Console.WriteLine("There are " + t + " days until Christmas");

		double width, height, woodLength, glassArea;
		string widthString, heightString;

		widthString = Console.ReadLine();
		width = double.Parse(widthString);

		heightString = Console.ReadLine();

		height = double.Parse(heightString);

		woodLength = 2 * (width + height) * 3.25;
		glassArea = 2 * (width * height);

		Console.WriteLine("The length of the wood is " +
		woodLength + " feet");

		Console.WriteLine("The area of the glass is " +
		glassArea + " square metres");



		Console.ReadKey();
	}
}
