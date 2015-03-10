using System;
using System.Globalization;
using System.Threading;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        while (true)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    {
                        Console.Write("Please enter a integer: ");
                        int userInput = int.Parse(Console.ReadLine());
                        Console.WriteLine(userInput + 1);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Please enter a double: ");
                        double userInput = double.Parse(Console.ReadLine());
                        Console.WriteLine(userInput + 1);
                        break;
                    }
                case 3:
                    {
                        Console.Write("Please enter a string: ");
                        string userInput = Console.ReadLine();
                        Console.WriteLine("{0}*", userInput);
                        break;
                    }
            }
            Console.WriteLine();
        }
    }
}
