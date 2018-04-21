using System;

namespace EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            int indexOfAt = email.IndexOf('@');

            int sumBefore = 0;

            for (int i = 0; i < indexOfAt; i++)
            {
                sumBefore += (int)email[i];
            }

            int sumAfter = 0;

            for (int i = indexOfAt + 1; i < email.Length; i++)
            {
                sumAfter += (int)email[i];
            }

            if (sumBefore - sumAfter >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
