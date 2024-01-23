internal class Program
{
    public static void Main()
    {
        int sum = 0;
        int sumTwo = 0;
        for (int i = 0; i <= 100; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);

        for (int i = 0;i <= 50; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                sumTwo += i;
            }
        }
        Console.WriteLine($"The sum of the even numbers between 1 and 50 is: {sumTwo} ");

    }
}
