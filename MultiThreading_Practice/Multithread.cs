using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading_Practice
{
    public  class Multithread
    {
        public static void fun1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread are Excutiable the time  : "+i);

                Thread.Sleep(200);
            }
        }

        public static void fun2()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("Thread are Excutiable the time  : " + i*2);
            }
        }
        public static void fun3()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(20);
                Console.WriteLine("Thread are Excutiable the time  : " + i * 5);
            }
        }
    }
}
