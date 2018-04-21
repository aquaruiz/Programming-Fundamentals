using System;

namespace Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string successOrError = Console.ReadLine();
                if (successOrError == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    Console.WriteLine(ShowSuccess(operation, message));
                }

                if (successOrError == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    Console.WriteLine(ShowError(operation, code)); 
                }
            }
        }

        static string ShowSuccess(string operation, string message)
        {
            return $"Successfully executed {operation}.\r\n" +
        $"==============================\r\n" +
        $"Message: {message}.";       
        }

        static string ShowError(string operation, int code)
        {
            string reason = "";
            if (code > 0)
            {
                reason = "Invalid Client Data";
            }
            else
            {
                reason = "Internal System Failure";
            }

            return $"Error: Failed to execute {operation}.\r\n" +
        $"==============================\r\n" +
        $"Error Code: {code}.\r\n" +
        $"Reason: {reason}.";
        }

    }
}
