class program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int minimumRandomValue = 0;
        int maximumRandomValue = 101;
        int number = random.Next(minimumRandomValue, maximumRandomValue);
        int sumOfMultiples = 0;
        int multiplicityOfThree = 3;
        int multiplicityOfFive = 5;
       
        for (int i = 0; i <= number; i++)
        {
            if (i % multiplicityOfThree == 0 || i % multiplicityOfFive == 0)
            {
                sumOfMultiples += i;
            }
        }
    }
}