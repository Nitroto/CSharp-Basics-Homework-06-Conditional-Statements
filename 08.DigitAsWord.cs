using System;
using System.Globalization;
using System.Threading;

class DigitAsWord
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        while (true)
        {
            string userInput = Console.ReadLine();
            int num;
            bool isNum = int.TryParse(userInput, out num);
            string word;
            if (isNum)
            {
                switch (num)
                {
                    case 1: word = "one"; break;
                    case 2: word = "two"; break;
                    case 3: word = "three"; break;
                    case 4: word = "four"; break;
                    case 5: word = "five"; break;
                    case 6: word = "six"; break;
                    case 7: word = "seven"; break;
                    case 8: word = "eight"; break;
                    case 9: word = "nine"; break;
                    case 0: word = "zero"; break;
                    default: word = "not a number"; break;
                }
            }
            else
            {
                word = "not a number";
            }
            Console.WriteLine(word);
        }
    }
}
