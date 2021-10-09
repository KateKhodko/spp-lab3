using System;
using System.Threading;

namespace spp_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            var mutex = new Mutex();
            for (var i = 0; i < n; i++)
            {
                new Thread(() =>
                    {
                        mutex.Lock();
                        Console.WriteLine("current Thread id: " + Thread.CurrentThread.ManagedThreadId + " lock Thread");
                        Thread.Sleep(200);
                        Console.WriteLine("current Thread id: " + Thread.CurrentThread.ManagedThreadId + " unlock Thread");
                        mutex.Unlock();
                    }
                ).Start();
            }
        }
    }
}