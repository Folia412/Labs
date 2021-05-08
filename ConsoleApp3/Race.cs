using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp3
{
    public class Race: IDisposable
    {
        private static ManualResetEvent manualResetEvent = new ManualResetEvent(false);
        public List<Thread> Results = new List<Thread>();
        public Race()
        {
            for (int i = 0; i < 10; i++)
            {
                var thread = new Thread(ThreadEntryPoint);
                if (i == 0)
                {
                    thread.Priority = ThreadPriority.Highest;
                }
                else if (i == 9)
                {
                    thread.Priority = ThreadPriority.Lowest;
                }
                else
                {
                    thread.Priority = ThreadPriority.Normal;
                }
                thread.Name = "I am thread # " + i;
                thread.Start();
            }

        }
        private void ThreadEntryPoint()
        {
            manualResetEvent.WaitOne();
            Console.WriteLine(Thread.CurrentThread.Name);
            Results.Add(Thread.CurrentThread);
        }
        public void Start()
        {
            manualResetEvent.Set();
        }
        public void Dispose()
        {
            manualResetEvent.Dispose();
        }
    }
}
