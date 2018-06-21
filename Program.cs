using System;

namespace nlog_console
{
    class Program
    {
        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            log.Trace("Loggin trace.");
        }
    }
}
