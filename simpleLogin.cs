namespace TaskTwo;
internal class Program
{
    public static void Main()
    {
        string username = "player1";
        string pass = "pass123";
        string secWord = "dragon";
        string typUser, typPass, typWord;

        Console.WriteLine("Enter your username: ");
        typUser = Console.ReadLine();

        while (typUser != username) 
        {
            Console.WriteLine("Incorrect username, try again: ");
            typUser = Console.ReadLine();
        }

        Console.WriteLine("Enter your password: ");
        typPass = Console.ReadLine();

        while (typPass != pass)
        {
            Console.WriteLine("Incorrect password, try again: ");
            typPass = Console.ReadLine();
        }

        Console.WriteLine("Enter the secret word: ");
        typWord = Console.ReadLine();

        while (typWord != secWord)
        {
            Console.WriteLine("Incorrect secret word, try again: ");
            typWord = Console.ReadLine();
        }
        if (typUser == username && typPass == pass && typWord == secWord) 
        {
            Console.WriteLine("Congratulations you are now logged in. ");
        }
        else
        {
            Console.WriteLine("You couldnt log in try again.");
        }
    }
}
