//using Practice.Delegate;
//using System;
//using System.Threading;

//class MultiThread
//{
//    static void Main()
//    {
//        Console.WriteLine("Main thread starting.");
//        // First, construct a MyThread object.
//        MyThread mt = new MyThread("Child #1");
//        // Next, construct a thread from that object.
//        Thread newThrd = new Thread(mt.Run);
//        // Finally, start execution of the thread.
//        newThrd.Start();
//        do
//        {
//            Console.Write(".");
//            Thread.Sleep(100);
//        } while (mt.Count != 10);
//        Console.WriteLine("Main thread ending.");
//    }
//}