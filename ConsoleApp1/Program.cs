using SF2022UserLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan[] timeSpans = {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0)
            };

            int[] durations =
             {
               60,
               30,
               10,
               10,
               40
             };

            TimeSpan start = new TimeSpan(8, 0, 0);
            TimeSpan end = new TimeSpan(18, 0, 0);
            int consult = 30;
            var t = Calculations.AvailablePeriods(timeSpans, durations, start, end, consult);
            t.ToList().ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}
