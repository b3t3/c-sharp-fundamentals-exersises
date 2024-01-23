using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    public static void Main()
    {
        int randNumb = new Random().Next(1, 100);
        int typNum;
        string input;

        Console.WriteLine("Guess the number between 1 and 100: ");
        input = Console.ReadLine();
        Int32.TryParse(input, out typNum);

        while (typNum != randNumb)
        {
            if (randNumb > typNum)
            {
                Console.WriteLine("The number is higher,try again: ");
                input = Console.ReadLine();
                Int32.TryParse(input, out typNum);
            }
            else if (randNumb < typNum)
            {
                Console.WriteLine("The number is lower,try again: ");
                input = Console.ReadLine();
                Int32.TryParse(input, out typNum);
            }
            else 
            {
                Console.WriteLine("Gongrats you guessed it!!!");
            }
        }
        Console.WriteLine($"The number was{randNumb}");
    }
}
