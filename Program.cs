namespace MultiplePolymorph;

class Program
{
    static void Main(string[] args)
    {
        int[] Range = {1 , 100};
        
        SimpleMultiple MS = new SimpleMultiple();

        MS.FindMultiple(Range[0], Range[1]);

        Console.WriteLine("End of execution.");
    }
}
