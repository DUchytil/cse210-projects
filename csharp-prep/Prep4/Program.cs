using System;
using System.Globalization;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        bool finished = false;
        float sum = 0;
        int largestNumber = 0;

        List<int> list = new List<int>();

        while (!finished)
        {
            Console.Write("Enter number: ");
            int entry = int.Parse(Console.ReadLine());
            if (entry == 0)
                break;
            list.Add(entry);
        }

        foreach (int num in list)
        {
            if (num > largestNumber)
                largestNumber = num;

            sum += num;
        }

        float average = sum / list.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}