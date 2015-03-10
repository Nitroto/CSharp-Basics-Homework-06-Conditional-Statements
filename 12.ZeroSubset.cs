using System;
using System.Globalization;
using System.Threading;

class ZeroSubset
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        while (true)
        {
            string[] userInput = Console.ReadLine().Split(' ');
            int[] nums = new int[userInput.Length];
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(userInput[i]);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    counter++;
                    Console.WriteLine("{0}=0", nums[i]); 
                }
            }
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == 0)
                    {
                        counter++;
                        Console.WriteLine("({0})+({1})=0", nums[i], nums[j]);
                    }
                }
            }
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = 1; j < nums.Length - 1; j++)
                {
                    for (int k = 2; k < nums.Length; k++)
                    {
                        if ((nums[i] + nums[j] + nums[k]) == 0)
                        {
                            counter++;
                            Console.WriteLine("({0})+({1})+({2})=0", nums[i], nums[j], nums[k]);
                        }
                    }
                }
            }
            for (int i = 0; i < nums.Length - 3; i++)
            {
                for (int j = 1; j < nums.Length - 2; j++)
                {
                    for (int k = 2; k < nums.Length - 1; k++)
                    {
                        for (int l = 3; l < nums.Length; l++)
                        {
                            if ((nums[i] + nums[j] + nums[k] + nums[l]) == 0)
                            {
                                counter++;
                                Console.WriteLine("({0})+({1})+({2})+({3})=0", nums[i], nums[j], nums[k], nums[l]);
                            }
                        }
                    }
                }
            }
            if ((nums[0] + nums[1] + nums[2] + nums[3] + nums[4]) == 0)
            {
                counter++;
                Console.WriteLine("({0})+({1})+({2})+({3})+({4})=0", nums[0], nums[1], nums[2], nums[3], nums[4]);
            }
            if (counter == 0)
            {
                Console.WriteLine("no zero subset");
            } 
        }
    }
}
