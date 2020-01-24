using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SemaphoreExample
{
    public static class Global
    {
        public static readonly Semaphore Semaphore = new Semaphore(1, 1);
    }
}
