using System;
using System.Globalization;
using System.Threading;

class CheckForAPlayCard
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        while (true)
        {
            string card = Console.ReadLine();
            string[] cardFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            bool isCard = false;
            foreach (string face in cardFaces)
            {
                if (String.Equals(card, face))
                {
                    isCard = true;
                }
            }
            Console.WriteLine(isCard ? "Yes" : "No"); 
        }
    }
}
