using System;
using System.Globalization;
using System.Threading;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        while (true)
        {
            int n = 3;
            double biggest = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                double userValue = double.Parse(Console.ReadLine());
                if (userValue > biggest)
                {
                    biggest = userValue;
                }
            }
            Console.WriteLine(biggest); 
        }
    }
}
