using System;
using System.Collections.Generic;
using System.Text;

namespace SemaphoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Go(args);
            }
            catch (Exception x)
            {
                if (!string.IsNullOrEmpty(x.Message))
                {
                    Console.WriteLine("Exception: {0}", x.Message);
                }
            }
            Console.ReadLine();
        }

        private static void Go(string[] args) => new App().Start();
    }
}
