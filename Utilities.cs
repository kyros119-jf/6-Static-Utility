namespace StaticUtilityTools
{
    public static class Utilities
    {

public static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Text Utility!");
        }

public static string ConvertToUpperCase(string text)
        {
            return text.ToUpper();
        }


public static int CountCharacters(string text)
        {
            return text.Length;
        }

    }

}


