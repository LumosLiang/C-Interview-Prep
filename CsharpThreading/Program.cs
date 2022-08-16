using System;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpThreading
{
    class ThreadPractice
    {
        private bool isCompleted1;
        private static bool isCompleted2;
        private static object Lock = new object();
        static int _val1 = 1, _val2 = 1;

        static object Lock1 = new object(), Lock2 = new object();

        // The thread actualling creating this mutex does not have the ownership for this mutex
        // 
        static Mutex mutex = new Mutex(false, "Got Mutex");
        static SemaphoreSlim semapS = new SemaphoreSlim(5);

        static void Main(string[] args)
        {

            #region Basic
            // CreateThread();
            // NamingThreadForDebug();
            // ThreadSharedResourceWithoutLock();
            // ThreadSharedResourceUseLock();
            // BackgroundThread();
            // ThreadExceptionHandling();
            // CreateThreadPoolByTask();
            #endregion

            #region Block

            // LockingPractice();
            // Deadlock();

            // mutex two ways to use it:
            // MutexPractice1();
            // MutexPractice2();
            SemaphorePractice();
            #endregion

        }

        private static void SemaphorePractice()
        {

            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(EnterSemaphore);
                t.Name = string.Format("Thread {0}", i);
                t.Start();
            }
        }

        private static void EnterSemaphore(object obj)
        {
            Console.WriteLine("{0} Prepare to get semaphore", Thread.CurrentThread.Name);
            semapS.Wait();
            Console.WriteLine("{0} Get the semaphore", Thread.CurrentThread.Name);


            // semapS.Release();
        }

        // 1. mutex.waitone(), 
        // waitione: any thread that come here wait here first and once I got the signal, I will let you know. Then which get the mutex can access
        private static void MutexPractice1()
        {

            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(AcquireMutex);
                t.Name = string.Format("Thread {0}", i);
                t.Start();
            }
        }

        // The following resource
        // 2.mutex.waitone(timespan)
        private static void MutexPractice2()
        {

            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(AcquireMutex2);
                t.Name = string.Format("Thread {0}", i);
                t.Start();
            }
        }

        private static void AcquireMutex2()
        {
            if (!mutex.WaitOne(TimeSpan.FromSeconds(3), false))
            {
                Thread.Sleep(2000);
                Console.WriteLine("Mutext acquired by {0}", Thread.CurrentThread.Name);
                return;
            }
            mutex.ReleaseMutex();
            Console.WriteLine("Mutext released by {0}", Thread.CurrentThread.Name);
        }

        private static void AcquireMutex()
        {
            mutex.WaitOne();

            Thread.Sleep(2000);
            Console.WriteLine("Mutext acquired by {0}", Thread.CurrentThread.Name);

            mutex.ReleaseMutex();
            Console.WriteLine("Mutext released by {0}", Thread.CurrentThread.Name);
        }

        private static void Deadlock()
        {
            Thread t1 = new Thread(TestDeadLock);

            t1.Start();
            lock (Lock2)
            {
                Console.WriteLine("Main Thread wants Lock1");
                lock (Lock1) { };
            }
        }

        private static void TestDeadLock(object obj)
        {
            lock (Lock1)
            {
                Console.WriteLine("Child Thread wants Lock2");
                lock (Lock2) { };
            }
        }

        private static void LockingPractice()
        {
            Thread t1 = new Thread(divide);
            Thread t2 = new Thread(divide);

            t1.Start();
            t2.Start();
        }

        private static void divide(object obj)
        {

            //if (_val2 != 0) Console.WriteLine(_val1 / _val2);
            //_val2 = 0;

            //  C#’s lock statement is in fact a syntactic shortcut for a call to the methods Monitor.Enter and Monitor.Exit, with a try/finally block.

            Monitor.Enter(Lock);
            try
            {
                if (_val2 != 0) Console.WriteLine(_val1 / _val2);
                _val2 = 0;
            }
            finally
            {
                Monitor.Exit(Lock);
            }

        }

        private static void CreateThreadPoolByTask()
        {
            var task1 = Task.Factory.StartNew(DoSthInChildThread);
            Action<object> action = (object obj) =>
            {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}",
                Task.CurrentId,
                obj,
                Thread.CurrentThread.ManagedThreadId);
            };

            // Create a task but do not start it.
            Task task2 = new Task(action, "alpha");

            // Construct a started task
            Task task3 = Task.Factory.StartNew(action, "beta");
            // Block the main thread to demonstrate that t3 is executing
            task3.Wait();

            // start task2
            task2.Start();
            Console.WriteLine("t1 has been launched. (Main Thread={0})",
                         Thread.CurrentThread.ManagedThreadId);
            task2.Wait();

            // Construct a started task using Task.Run
            String taskData = "delta";

            Task task4 = Task.Run(() =>
            {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}",
                      Task.CurrentId, taskData,
                       Thread.CurrentThread.ManagedThreadId);
            });
            task4.Wait();

            // Construct an unstarted task
            Task task5 = new Task(action, "gamma");
            // Run it synchronously
            task5.RunSynchronously();
            // Although the task was run synchronously, it is a good practice
            // to wait for it in the event exceptions were thrown by the task.
            task5.Wait();

        }

        private static void BackgroundThread()
        {
            Thread worker = new Thread(() => Console.ReadLine());
            var k = Console.ReadLine();
            if (k == "test") worker.IsBackground = true;
            worker.Start();
        }


        private static void NamingThreadForDebug()
        {
            Thread.CurrentThread.Name = "Main Thread";
            Thread workerthread = new Thread(DoSthInChildThread);
            workerthread.Name = "Worker";
            workerthread.Start();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main: " + i.ToString());
                Thread.Sleep(2000);
            }
        }

        private static void ThreadSharedResourceWithoutLock()
        {
            Thread.CurrentThread.Name = "Main Thread";
            Thread workerthread = new Thread(PrintHelloWorld);
            workerthread.Start();
            PrintHelloWorld();
        }


        private static void PrintHelloWorld()
        {
            if (!isCompleted2)
            {
                Console.WriteLine("Hello world should print only once");
                isCompleted2 = true;
            }
        }

        private static void ThreadSharedResourceUseLock()
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
                if (!isCompleted2)
                {
                    Console.WriteLine("Hello world should print only once");
                    isCompleted2 = true;
                }
            }
        }

        public static void CreateThread()
        {
            PrintMainThread();
            // initialize 1
            ThreadStart childref = new ThreadStart(DoSthInChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            
            Thread childthread1 = new Thread(childref);


            // initialize 2
            Thread childthread2 = new Thread(DoSthInChildThread);
            childthread2.Start();
        }

        public static void ThreadExceptionHandling()
        {

            Console.WriteLine("In Main: Creating the Child abort test thread");
            Thread worker = new Thread(CatchExceptionWhenAbortChildThread);


            worker.Start();

               
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("In Main print number:" + i.ToString());
                Thread.Sleep(2000);
            }

            Console.WriteLine("In Main: abort the Child ");
            worker.Abort();
            Console.ReadKey();
        }

        public static void PrintMainThread()
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine("This is {0}", mainThread.Name);
        }

        public static void DoSthInChildThread()
        {
            Console.WriteLine("Child starts");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Child: " + i.ToString());
                Thread.Sleep(2000);
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
            catch (PlatformNotSupportedException e)
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
