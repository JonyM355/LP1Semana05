using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1;
            Stopwatch crono2;
            crono1 = new Stopwatch();
            crono2 = new Stopwatch();
            crono1.Start();
            Thread.Sleep(600);
            crono2.Start();
            Thread.Sleep(200);
            crono1.Stop();
            crono2.Stop();
            TimeSpan crono1_TimeSpan = crono1.Elapsed;
            TimeSpan crono2_TimeSpan = crono2.Elapsed;

            string crn1_ElapsedTime =
            String.Format("{0:00}:{1:00}.{2:00}", 
            crono1_TimeSpan.Minutes, 
            crono1_TimeSpan.Seconds,
            crono1_TimeSpan.Milliseconds / 10);

            string crn2_ElapsedTime = 
            String.Format("{0:00}:{1:00}.{2:00}",
            crono2_TimeSpan.Minutes, 
            crono2_TimeSpan.Seconds,
            crono2_TimeSpan.Milliseconds / 10);

            Console.WriteLine("RunTime crono1: " + crn1_ElapsedTime);
            Console.WriteLine("RunTime crono2: " + crn2_ElapsedTime);
        }
    }
}
