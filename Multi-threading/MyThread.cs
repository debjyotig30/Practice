using Practice;
using System;
using System.Threading;
class MyThread : IPractice
{

    public void execute()
    {
        Thread t1 = new Thread(new ThreadStart(FirstFunction));
        Thread t2 = new Thread(new ThreadStart(SecondFunction));

        t1.Start();
        t2.Start();
    }

    public void FirstFunction()
    {
        for(int i = 0; i < 100; i++ )
        {
            Thread.Sleep(1000);
            Console.WriteLine("Fn1");
        }
    }

    public void SecondFunction()
    {
        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Fn2");
        }
    }
}