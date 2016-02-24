using AddinView;
using System;
using System.AddIn;

namespace AddinV1
{
    [AddIn("AddinV1")]
    public class Addin : IV1
    {
        public string GetName()
        {
            return "Addin V1";
        }

        public void WriteToConsole()
        {
            Console.WriteLine("Hello World!");
        }
    }
}