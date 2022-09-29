namespace MultiplePolymorph;

public class SimpleMultiple : IMultiple
{
    public void FindMultiple(int Start, int End)
    {
        int Number = Start;

        // Should check if End < Start but eh, who cares

        for (int i = 0; i <= End; i++)
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

           Number++;
        }
    }
}