namespace Assignments.Assignment_5;

class Assignment5
{
    public static void Run()
    {
        try
        {
            int num = 0 / 10;
        }

        catch (DivideByZeroException e)
        {
            Console.WriteLine(e);
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("Calculation done.");
        }
        
        #if DEBUG
        Console.WriteLine("You are in debugging mode");
        #endif

        List<string> users = new List<string> { "Sam", "John", "Mike" };

        Console.WriteLine(users);

        void checkUser(string user)
        {
            if (user == "Mike")
            {
                throw new UserBannedException($"{user} is banned");
            }
            else
            {
                Console.WriteLine($"User {user} is active");
            }
        }

        foreach (var user in users)
        {
            checkUser(user);
        }

    }
}