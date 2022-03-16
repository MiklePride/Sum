class program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int number = rand.Next(0, 101);
        int multiplicity = 5;
        Console.WriteLine(number);
        
        for (int i = multiplicity; i < number; i += 5)
        {
            Console.WriteLine(i);
        }
        
    }
}