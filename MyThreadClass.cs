using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPriority_Reyes
{
    internal class MyThreadClass
    {
        public static void thread1()
        {
            for (int loopCount = 0; loopCount < 2; loopCount++)
            {
                Thread thread = Thread.CurrentThread; 
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);

                Thread.Sleep(500);
            }
        }
        public static void thread2()
        {
            for (int loopCount = 0; loopCount < 6; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);

                Thread.Sleep(1500);
            }
        }
    }
}
