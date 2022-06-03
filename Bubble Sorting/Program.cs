using System;

namespace Bubble_Sorting_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] squidy = { 42, 13, 61, 29, 7, 9, 16, 37 };

            int temp = 0;
            int posi = 0;
            for (int i = 0; i <= squidy.Length - 2; i++)
            {
                for (int j = 0; j <= squidy.Length - 2; j++)
                {
                    posi = posi + 1;
                    if (squidy[i] > squidy[j])
                    { // just testing some stuff but i need to move to my main pc
                        temp = squidy[i++];
                        int maxima = (int)squidy.GetValue(i);
                        int tempSave = (int)squidy.GetValue(j);
                        squidy.SetValue(i, tempSave);
                        squidy.SetValue(j);
                        Console.WriteLine(minima);
                    }
                }
            }

        }
    }
}
