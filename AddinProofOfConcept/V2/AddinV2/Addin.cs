using AddinViewV2.V2;
using System;
using System.AddIn;
using System.AddIn.Pipeline;
using System.Diagnostics;
using System.Timers;

namespace AddinV2.V2
{
    [AddIn("Addin V2", Version = "2.0.0.0")]
    public class Addin : IV2
    {
        private ICallbackV2 _callback;

        public string GetName()
        {
            return "Addin V2";
        }

        public void Initialize(ICallbackV2 callback)
        {
            _callback = callback;
        }

        public void WriteToConsole(string output)
        {
            Console.WriteLine("Writing output from host: {0}", output);
            _callback.DoWork();
        }

        public object GetSource()
        {
            return Stopwatch.StartNew();
        }
    }
}