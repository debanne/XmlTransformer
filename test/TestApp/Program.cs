using System;
using System.Configuration;

namespace TestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var isDebugMode = ConfigurationManager.AppSettings["DebugMode"];
            Console.WriteLine("debugMode=" + isDebugMode);
        }
    }
}
