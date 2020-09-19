using System;
class ConsoleApp
{
    public static void Main()
    {
        string k = "Kate Lewis";
        string va = "Richmond, Virginia";

        DateTime today = DateTime.Today;

        DateTime daysLeft = DateTime.Parse("12/25/2020");

        //Calculate countdown timer.
        TimeSpan t = (daysLeft - today);
        int countDown = t.Days;


        Console.WriteLine("My name is " + k + ".");
        Console.WriteLine("I am from " + va + ".");
        Console.WriteLine($"This is string interpolation: My name is {k}, and I am from {va}.");
        Console.WriteLine("Today is " + today.ToString("MM/dd/yyyy"));
        Console.WriteLine("There are " + t.Days + " days until Christmas");
        Console.WriteLine("press any key to continue");
        Console.ReadKey();


        //code for calculations
        double width, height, woodLength, glassArea;
        string widthString, heightString;

        Console.Write("Please enter the width:");
        widthString = Console.ReadLine();
        Console.WriteLine("press any key to continue");
        Console.ReadKey();

        Console.Write("Please enter the height:");
        heightString = Console.ReadLine();
        Console.WriteLine("press any key to continue");
        Console.ReadKey();

        width = double.Parse(widthString);
        height = double.Parse(heightString);
        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);


        Console.WriteLine("The length of the wood is " + woodLength + " feet");
        Console.WriteLine("The area of the glass is " + glassArea + " square metres");

        Console.WriteLine("press any key to exit");
        Console.ReadLine();
    }
}