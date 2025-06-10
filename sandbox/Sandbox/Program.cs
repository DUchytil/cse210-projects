using System;
using System.Diagnostics.Tracing;
using System.IO.Compression;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Circle myCircle = new Circle();
        // myCircle.SetRadius(10);
        // Console.WriteLine($"{myCircle.GetRadius()}");

        // Circle myCircle2 = new Circle();
        // myCircle2.SetRadius(20);
        // Console.WriteLine($"{myCircle2.GetRadius()}");

        // Console.WriteLine($"{myCircle.GetArea()}");
        // Console.WriteLine($"{myCircle2.GetArea()}");

        // Cylinder myCylinder = new Cylinder();
        // myCylinder.SetHeight(10);
        // myCylinder.SetCircle(myCircle);
        // Console.WriteLine($"{myCylinder.GetVolume()}");
        Console.WriteLine("Hello world");

        int duration = 9;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);
        int sleepTime = 250;
        int count = duration;


        string animationString = "(^_^)(-_-)";



        while (DateTime.Now < endTime) //Countdown code 
        {
            Console.Write(animationString[0..5]); //Puts down first five characters
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString[5..]); //put down last five characeters
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");

        }

        // while (DateTime.Now < endTime) //Countdown code 
        // {
        //     Console.Write(count--);
        //     Thread.Sleep(1000);
        //     Console.Write("\b");

        // }

        // while (DateTime.Now < endTime)
        //     {
        //         Console.Write("+");
        //         Thread.Sleep(sleepTime); //Function takes milliseconds 
        //         Console.Write("\b"); //moving the curser over one spot
        //         Console.Write("-");
        //         Thread.Sleep(sleepTime); //Function takes milliseconds 
        //         Console.Write("\b"); //moving the curser over one spot
        //     }



    }
}   