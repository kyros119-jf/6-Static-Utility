namespace StaticUtilityApp.Utilities
{
    public static class Utilities
    {

public static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Text Utility!");
        }

public static string convertToUpperCase(string text)
        {
            return text.ToUpper();
        }


public static int CountCharacters(string text)
        {
            return text.Length;
        }




    }




}


