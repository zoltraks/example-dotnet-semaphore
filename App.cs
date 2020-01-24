using System;
using System.Collections.Generic;
using System.Text;

namespace SemaphoreExample
{
    public class App
    {
        public void Start()
        {
            var p = new List<Worker>();
            for (int i = 0; i < 10; i++)
            {
                p.Add(new Worker());
            }
            foreach (var w in p)
            {
                w.Thread.Start();
            }
        }
    }
}
