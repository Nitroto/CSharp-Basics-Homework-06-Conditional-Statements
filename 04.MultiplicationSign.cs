using System;
using System.Globalization;
using System.Threading;

class MultiplicationSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        while (true)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine(0);
            }
            else if (a < 0 ^ b < 0 ^ c < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            } 
        }
    }
}
