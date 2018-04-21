using System;

namespace CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string thiefIdType = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            long maxValue = 0;

            switch (thiefIdType)
            {
                case "sbyte":
                    maxValue = sbyte.MaxValue;
                    break;
                case "int":
                    maxValue = int.MaxValue;
                    break;
                case "long":
                    maxValue = long.MaxValue;
                    break;
            }

            long thiefId = long.MinValue;
            for (int i = 0; i < n; i++)
            {
                var id = long.Parse(Console.ReadLine());

                if (id <= maxValue)
                {
                    if (id > thiefId)
                    {
                        thiefId = id;
                    }
                }
            }

            Console.WriteLine(thiefId);
        }
    }
}
