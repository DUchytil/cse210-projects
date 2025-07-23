using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the grad percentage: ");
        int percentage = int.Parse(Console.ReadLine());
        bool passed;
        string grade;
        if (percentage >= 70)
            passed = true;
        else
            passed = false;

        if (percentage >= 90)
            grade = "A";
        else if (percentage >= 80)
            grade = "B";
        else if (percentage >= 70)
            grade = "C";
        else if (percentage >= 60)
            grade = "D";
        else
            grade = "F";

        Console.WriteLine($"Your letter grade is {grade}. Passed class: {passed}");
        if (passed)
            Console.WriteLine("Gongrats! You passed!!");
    }
}