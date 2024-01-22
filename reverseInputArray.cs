namespace TaskFour;
internal class Program
{
    public static void Main() 
    {
        Console.WriteLine("Enter numbers and separate them with spaces: ");
        string numbers = Console.ReadLine();

        string[] arr = numbers.Split();
        Array.Reverse(arr);

        foreach (string s in arr) Console.WriteLine(s);
    }
}