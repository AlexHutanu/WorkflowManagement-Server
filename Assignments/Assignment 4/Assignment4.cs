using System.Globalization;

class Assignment4
{
    public static void Main()
    {
        string[] array = { "Hello", "World" };

        string text = string.Join(" ", array);

        TimeSpan interval = new TimeSpan(5, 9, 19);

        DateTime now = DateTime.Now;

        DateTime date = new DateTime(2023, 01, 01);

        DateTimeOffset dateNow = DateTimeOffset.Now;

        CultureInfo enUs = new CultureInfo("en-US");
        
        Console.WriteLine(enUs.DisplayName);

    }
}