namespace TaskThree;
internal class Program
{
    public static void Main()
    {
        int sum = 0;

        Console.WriteLine("Enter numbers and separate them with spaces: ");
        string numbers = Console.ReadLine();

        string[] arr = numbers.Split();

        foreach (var num in arr)
        {
            sum += int.Parse(num);
        }

        Console.WriteLine(sum);
    }
}