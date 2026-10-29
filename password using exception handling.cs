using System;
using static System.Console;
class Program
{
    static string password()
    {  
        while(true)
        {
        try
        {
            string now = ReadLine();
            if(string.IsNullOrEmpty(now))
            {
                throw new ArgumentException("your password cannt be empty.\npleae try again");
            }
            if(!now.Any(char.IsDigit))
            {
                throw new ArgumentException("at least 1 digit(0-9) must contain in password");
            }
        return now;
        }
        catch(ArgumentException A)
        {
            WriteLine(A.Message);
        }   
        }
    }
    public static void Main()
    {
        string s = password();
        WriteLine("ok come here");
    }
}
