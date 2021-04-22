using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchSim
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            string response;
            bool isStarted = true;

            while (isStarted)
            {

                Console.WriteLine("Enter 'S' to start \nEnter 'P' to stop \nEnter 'R' to reset: \n");
                response = Console.ReadLine().ToUpper();

                if (response == "S")
                {
                    stopWatch.SetStart();
                }
                else if (response == "P")
                {
                    stopWatch.SetStop();
                    Console.WriteLine(stopWatch.GetDuration().Hours + " hours, " +
                        stopWatch.GetDuration().Minutes + " minutes, " +
                        stopWatch.GetDuration().Seconds.ToString() + " seconds.\n");
                }
                else if (response == "R")
                {
                    stopWatch.Reset();
                }
                else
                {
                    throw new InvalidOperationException("Please write 'S', 'P' or 'R'");
                }
            }
        }
    }
}
