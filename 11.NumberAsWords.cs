using System;
using System.Globalization;
using System.Threading;

class NumberAsWords
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            string word;
            if (n >= 0 && n < 20)
            {
                word = GetUnits(n);
            }
            else if (n >= 20 && n < 100)
            {
                int tenths = (n / 10) % 10;
                int units = n % 10;
                if (units == 0)
                {
                    word = GetTenths(tenths);
                }
                else
                {
                    word = GetTenths(tenths) + " " + GetUnits(units).ToLower();
                }
            }
            else
            {
                int hundreds = (n / 100) % 10;
                int tenths = (n / 10) % 10;
                int units = n % 10;

                if (tenths == 1)
                {
                    units = n % 100;
                    if (n == 100)
                    {
                        word = GetHundreds(hundreds);
                    }
                    else
                    {
                        word = GetHundreds(hundreds) + " and " + GetUnits(units).ToLower();
                    }
                }
                else
                {
                    if (tenths == 0 && units != 0)
                    {
                        word = GetHundreds(hundreds) + " and " + GetUnits(units).ToLower();
                    }
                    else if (tenths == 0 && units == 0)
                    {
                        word = GetHundreds(hundreds);
                    }
                    else
                    {
                        word = GetHundreds(hundreds)+ " and "+ GetTenths(tenths).ToLower()+" "+GetUnits(units).ToString();
                    }
                    
                }
            }
            Console.WriteLine(word); 
        }
    }

    private static string GetUnits(int n)
    {
        string word = "";
        switch (n)
        {
            case 0: word = "Zero"; break;
            case 1: word = "One"; break;
            case 2: word = "Two"; break;
            case 3: word = "Three"; break;
            case 4: word = "Four"; break;
            case 5: word = "Five"; break;
            case 6: word = "Six"; break;
            case 7: word = "Seven"; break;
            case 8: word = "Eight"; break;
            case 9: word = "Nine"; break;
            case 10: word = "Ten"; break;
            case 11: word = "Eleven"; break;
            case 12: word = "Twelve"; break;
            case 13: word = "Thirteen"; break;
            case 14: word = "Fourteen"; break;
            case 15: word = "Fifteen"; break;
            case 16: word = "Sixteen"; break;
            case 17: word = "Seventeen"; break;
            case 18: word = "Eighteen"; break;
            case 19: word = "Nineteen"; break;
        }
        return word;
    }

    private static string GetTenths(int n)
    {
        string word="";
        switch (n)
        {
            case 2: word = "Twenty"; break;
            case 3: word = "Thirty"; break;
            case 4: word = "Forty"; break;
            case 5: word = "Fifty"; break;
            case 6: word = "Sixty"; break;
            case 7: word = "Seventy"; break;
            case 8: word = "Eighty"; break;
            case 9: word = "Ninety"; break;
        }
        return word;
    }

    private static string GetHundreds(int n)
    {
        string word = "";
        switch (n)
        {
            case 1: word = "One hundred"; break;
            case 2: word = "Two hundred"; break;
            case 3: word = "Three hundred"; break;
            case 4: word = "Four hundred"; break;
            case 5: word = "Five hundred"; break;
            case 6: word = "Six hundred"; break;
            case 7: word = "Seven hundred"; break;
            case 8: word = "Eight hundred"; break;
            case 9: word = "Nine hundred"; break;
        }
        return word;
    }
}
