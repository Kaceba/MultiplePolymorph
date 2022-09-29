namespace MultiplePolymorph;

using System.Linq;
public class RandomMultiple : IMultiple
{
    public int FindMultiple(int Start, int End)
    {

        List<int> Values = new List<int>();

        if (Start >= End)
        {
            Console.WriteLine("Incorrect values for range");
            return 1;
        }

        Random rand = new Random();

        for(int i = 0; i < 100; i++)
        {
            Values.Add(rand.Next(1, 101));
        }

        Values.Sort();

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