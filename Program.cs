using StaticUtilityTools;


namespace StaticUtilityApp
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Utilities.DisplayWelcome();


            Console.WriteLine("Enter some text:");
            string input = Console.ReadLine() ?? "";

            string upperCaseText = Utilities.ConvertToUpperCase(input);
            int characterCount = Utilities.CountCharacters(input);

            Console.WriteLine($"Uppercase: {upperCaseText}");
            Console.WriteLine($"Character Count: {characterCount}");
        }
    }
}