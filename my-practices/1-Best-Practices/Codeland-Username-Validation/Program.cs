using System;

class MainClass
{

    public static string CodelandUsernameValidation(string str)
    {

        // code goes here  
        Console.WriteLine("Enter a valid User Name : ");
        var userNameInput = Console.ReadLine();
        if (userNameInput < 25 && userNameInput > 4)
        {
            
        }
        return str;

    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));
    }

}