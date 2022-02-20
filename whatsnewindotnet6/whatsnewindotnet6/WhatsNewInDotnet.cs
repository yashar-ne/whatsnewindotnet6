using System;
using System.Threading;

class WhatsNewInDotnet
{

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