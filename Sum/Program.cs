class program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int number = rand.Next(0, 101);
        int sum = 0;
        int multiplicityOfThree = 3;
        int multiplicityOfFive = 5;
       
        for (int i = 0; i <= number; i++)
        {
            if (i % multiplicityOfThree == 0 || i % multiplicityOfFive == 0)
            {
                sum += i;
            }
            else
            {
                continue;
            }
        }
    }
}