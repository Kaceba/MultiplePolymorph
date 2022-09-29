namespace MultiplePolymorph;

using System.Collections.Generic;

public class ListMultiple : IMultiple
{
    public int FindMultiple(int Start, int End)
    {
        List<int> Values = new List<int>();
        int i = 0;

        if (Start >= End)
        {
            Console.WriteLine("Incorrect values for range");
            return 1;
        }

        for (int Number = Start; Number <= End; Number++)
        {
            Values.Add(Number);
            i++;
        }

        foreach (var Number in Values)
        {
            if(Number %2 == 0)
            {
                Console.WriteLine($"{Number} is a multiple of 2");
            }
            if(Number %3 == 0)
            {
                Console.WriteLine($"{Number} is a multiple of 3");
            }
            if(Number %5 == 0)
            {
                Console.WriteLine($"{Number} is a multiple of 5");
            }
            if(Number %7 == 0)
            {
                Console.WriteLine($"{Number} is a multiple of 7");
            }
        }

        return 0;
    }
}