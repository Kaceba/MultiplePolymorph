namespace MultiplePolymorph;

public class SimpleMultiple : IMultiple
{
    public int FindMultiple(int Start, int End)
    {
        int Number = Start;

        if(Start >= End)
        {
            Console.WriteLine("Incorret values for range");
            return 1;
        }

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

        return 0;
    }
}