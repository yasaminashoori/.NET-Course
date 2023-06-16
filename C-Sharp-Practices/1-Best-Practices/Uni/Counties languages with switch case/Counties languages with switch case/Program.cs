class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a country name:");
        string country = Console.ReadLine();

        string language = GetLanguage(country);

        if (language != null)
        {
            Console.WriteLine($"The language spoken in {country} is {language}.");
        }
        else
        {
            Console.WriteLine($"The language spoken in {country} is unknown.");
        }

        Console.ReadLine();
    }

    static string GetLanguage(string country)
    {
        string language;

        switch (country.ToLower())
        {
            case "united states":
            case "britain":
                language = "English";
                break;
            case "germany":
                language = "German";
                break;
            case "france":
                language = "French";
                break;
            case "spain":
                language = "Spanish";
                break;
            case "japan":
                language = "Japanese";
                break;
            case "china":
                language = "Mandarin Chinese";
                break;
            case "russia":
                language = "Russian";
                break;
            case "iran":
                language = "Persian";
                break;
            case "iraq":
            case "emirates":
                language = "Arabic";
                break;
            default:
                language = null;
                break;

        }

        return language;
    }
}