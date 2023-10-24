using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Multithread m = new Multithread();
         //  Multithread.fun1();

            Thread th1 = new Thread(Multithread.fun1);
            Thread th2 = new Thread(Multithread.fun2);
            Thread th3 = new Thread(Multithread.fun3);
            th1.Start();
            th2.Start();
            th3.Start();
            Console.ReadLine();
        }
    }
}
