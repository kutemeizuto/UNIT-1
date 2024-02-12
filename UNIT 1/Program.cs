using System;

class Program
{
    static void Main()
    {
        double b, h, a;

        Console.WriteLine("Enter the base of the triangle:");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Only numeric input is accepted for the base. Please try again.");
        }

        Console.WriteLine("Enter the height of the triangle:");
        while (!double.TryParse(Console.ReadLine(), out h))
        {
            Console.WriteLine("Only numeric input is accepted for the height. Please try again.");
        }

        a = b * h / 2;

        Console.WriteLine("The area of the triangle is: " + a);
        Console.WriteLine("Press any key to close this window");
        Console.ReadLine();
    }
}
