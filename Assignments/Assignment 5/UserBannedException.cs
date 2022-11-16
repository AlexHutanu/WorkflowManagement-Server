namespace Assignments.Assignment_5;

public class UserBannedException : Exception
{
    public string ErrorMessage { get; set; }

    public UserBannedException(string message)
    {
        ErrorMessage = message;
        Console.WriteLine(message);
    }
}