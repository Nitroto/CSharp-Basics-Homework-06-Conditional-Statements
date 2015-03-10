using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        while (true)
        {
            DateTime timeNow = DateTime.Parse(Console.ReadLine());
            DateTime beerTimeStart = DateTime.Parse("1:00 PM");
            DateTime beerTimeEnd = DateTime.Parse("3:00 AM");
            if ((timeNow.Hour >= 13 && timeNow.Hour <= 23) || (timeNow.Hour >= 0 && timeNow.Hour < 3))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("not-beer time");
            } 
        }
    }
}
