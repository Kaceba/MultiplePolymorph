namespace MultiplePolymorph;
class Program
{
    static void Main(string[] args)
    {
        int Number = 1;
        
        for (int i = 0; i <= 100; i++)
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

        Console.WriteLine("End of execution.");
    }
}
