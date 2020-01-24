using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SemaphoreExample
{
    public class Worker
    {
        public Thread Thread { get; private set; }

        public string GetThreadId() => Thread.ManagedThreadId.ToString("X8");

        public Worker()
        {
            this.Thread = new Thread(Work)
            {
                IsBackground = true,
            };
        }

        public void Work()
        {
            if (!Global.Semaphore.WaitOne(0))
            {
                Console.WriteLine(GetThreadId() + " " + "Semaphore locked");
                Global.Semaphore.WaitOne();
            }
            try
            {
                Console.WriteLine(GetThreadId() + " " + "Entered semaphore");
                System.Threading.Thread.Sleep(500);
            }
            finally
            {
                Global.Semaphore.Release();
                Console.WriteLine(GetThreadId() + " " + "Released semaphore");
            }
        }
    }
}
