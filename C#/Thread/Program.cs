using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Threading;


class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        //Uncomment these to run sequentially
        //funwithoutthread();
        //funwithoutthread2();

        //Using Threads
        Thread slave1 = new Thread(funwithoutthread);
        slave1.Start();
        Thread slave2 = new Thread(funwithoutthread2);
        slave2.Start();

        //Console.ReadLine() can be used to hold the console open
        Console.ReadLine();
    }

    public static void funwithoutthread()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000); //Pause for 1 second
        }
    }

    public static void funwithoutthread2()
    {
        for (int i = 11; i < 20; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000); //Pause for 1 second
        }
    }
}

