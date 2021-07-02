using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Logicalpgrms
{
    class SimulateStopwatch
    {
        public static void Readinput()
        {
            // Create new stopwatch.
            Stopwatch stopwatch = new Stopwatch();

            Console.Write("Enter 0 To START  : ");
            int a = Convert.ToInt32(Console.ReadLine());

            // Begin timing.
            stopwatch.Start();

            // Do something.
            Console.Write("Enter 0 To STOP : ");
            int b = Convert.ToInt32(Console.ReadLine());

            // Stop timing.
            stopwatch.Stop();

            //result.
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}
