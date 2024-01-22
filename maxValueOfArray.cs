internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter numbers and separate them with spaces: ");
        string numbers = Console.ReadLine();

        string[] arr = numbers.Split();
        int[] intArr = Array.ConvertAll(arr, int.Parse);
        int maxValue = intArr.Max();
        Console.WriteLine(maxValue);
    }
}