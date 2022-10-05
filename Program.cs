namespace MultiplePolymorph;

class Program
{
    static void Main(string[] args)
    {
        int[] Range = {1 , 100};
        
        var Multiple = new SimpleMultiple(); //Basta cambiare il nome della classe dichiarata e si puo
                                           //Usufruire di tutti e 3 i serviz  

        int exit = Multiple.FindMultiple(Range[0], Range[1]);

        Console.WriteLine($"Process exited with return value {exit}");
    }
}
