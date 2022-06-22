using System;
using System.Threading;

namespace CsharpThreading
{
    class ThreadPractice
    {
        private static bool isCompleted;
        private static object Lock = new object();

        static void Main(string[] args)
        {
            // ThreadPractice1();
            // ThreadPractice2();
            // ThreadNameForDebug();
            // ThreadSharedResourceDemo1();
            ThreadSharedResourceDemo2();
        }

        private static void ThreadNameForDebug()
        {
            Thread.CurrentThread.Name = "Main Thread";
            Thread workerthread = new Thread(DoSthInChildThread);
            workerthread.Start();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main: " + i.ToString());
                Thread.Sleep(2000);
                Console.WriteLine("In Child: print number");
            }
        }

        private static void ThreadSharedResourceDemo1()
        {
            Thread.CurrentThread.Name = "Main Thread";
            Thread workerthread = new Thread(PrintHelloWorld);
            workerthread.Start();
            PrintHelloWorld();
        }


        private static void PrintHelloWorld()
        {
            if (!isCompleted)
            {
                Console.WriteLine("Hello world should print only once");
                isCompleted = true;
            }
        }

        private static void ThreadSharedResourceDemo2()
        {
            Thread.CurrentThread.Name = "Main Thread";
            Thread workerthread = new Thread(PrintHelloWorld2);
            workerthread.Start();
            PrintHelloWorld2();
            
        }

        private static void PrintHelloWorld2()
        {
            lock (Lock)
            {
                if (!isCompleted)
                {
                    Console.WriteLine("Hello world should print only once");
                    isCompleted = true;
                }
            }
        }

        public static void ThreadPractice1()
        {
            PrintMainThread();
            // initialize
            ThreadStart childref = new ThreadStart(DoSthInChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childthread1 = new Thread(childref);
            Thread childthread2 = new Thread(DoSthInChildThread);
            childthread1.Start();
        }

        public static void ThreadPractice2()
        {
            ThreadStart childref1 = new ThreadStart(CatchExceptionWhenAbortChildThread);
            Console.WriteLine("In Main: Creating the Child abort test thread");
            Thread childthread2 = new Thread(childref1);
            childthread2.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
                Console.WriteLine("In Main: print number");
            }

            Console.WriteLine("In Main: abort the Child ");
            childthread2.Abort();
            Console.ReadKey();
        }

        public static void PrintMainThread()
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine("This is {0}", mainThread.Name);
            Console.ReadKey();
        }

        public static void DoSthInChildThread()
        {
            Console.WriteLine("Child starts");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Child: " + i.ToString());
                Thread.Sleep(2000);
                Console.WriteLine("In Child: print number");
            }
        }

        public static void CatchExceptionWhenAbortChildThread()
        {
            try
            {
                Console.WriteLine("Child starts");
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(2000);
                    Console.WriteLine("In Child: print number");
                }
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Did not catach the ThreadAbortException type exception");
            }
        }

    }
}
