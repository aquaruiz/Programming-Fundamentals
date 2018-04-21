using System;

namespace TypeBoundaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberType = Console.ReadLine();

            switch (numberType)
            {
                case "int":
                    Console.WriteLine(int.MaxValue);
                    Console.WriteLine(int.MinValue);
                    break;
                case "uint":
                    Console.WriteLine(uint.MaxValue);
                    Console.WriteLine(uint.MinValue);
                    break;
                case "long":
                    Console.WriteLine(long.MaxValue);
                    Console.WriteLine(long.MinValue);
                    break;
                case "byte":
                    Console.WriteLine(byte.MaxValue);
                    Console.WriteLine(byte.MinValue);
                    break;
                case "sbyte":
                    Console.WriteLine(sbyte.MaxValue);
                    Console.WriteLine(sbyte.MinValue);
                    break;
                case "double":
                    Console.WriteLine(double.MaxValue);
                    Console.WriteLine(double.MinValue);
                    break;
                case "float":
                    Console.WriteLine(float.MaxValue);
                    Console.WriteLine(float.MinValue);
                    break;
            }
        }
    }
}
