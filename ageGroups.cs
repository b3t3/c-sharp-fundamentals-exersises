namespace TaskOne;
internal class Prograam
{
    public static void Main()
    {
        int age;

        Console.WriteLine("Enter your age: ");
        age = int.Parse(Console.ReadLine());

        while (age < 0 || age >= 120)
        {
            Console.WriteLine("Invalid age enter your again: ");
             age = int.Parse(Console.ReadLine());
        }

        if (age >= 0 && age <= 12) 
        { 
            Console.WriteLine("Your age group is Children");
        }
        else if (age >= 13 && age <= 19) 
        {
            Console.WriteLine("Your age group is Teenagers");
        }
        else if (age >= 20 && age <= 60)
        {
            Console.WriteLine("Your age group is Adults");
        }
        else if (age >= 60)
        {
            Console.WriteLine("Your age group is Seniors");
        }
        else 
        {
            Console.WriteLine("Data entered is invalid");
        }
    }
}