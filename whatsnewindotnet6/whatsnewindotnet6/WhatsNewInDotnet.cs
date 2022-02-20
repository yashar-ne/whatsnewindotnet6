using System;
using System.Threading;

class WhatsNewInDotnet
{

    // dotnet core 6 allows to change the code while running and apply it immediately
    static void Main()
    {

        while (true)
        {
            Print();
        }
    }

    private static void Print()
    {
        Thread.Sleep(2000);
        Console.WriteLine("Some nice output");
    }
}