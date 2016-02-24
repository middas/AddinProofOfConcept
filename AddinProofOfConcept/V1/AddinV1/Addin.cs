using AddinView.V1;
using System;
using System.AddIn;

namespace AddinV1.V1
{
    [AddIn("AddinV1")]
    public class Addin : IV1
    {
        private ICallback _callback;

        public string GetName()
        {
            return "Addin V1";
        }

        public void Initialize(ICallback callback)
        {
            _callback = callback;
        }

        public void WriteToConsole()
        {
            Console.WriteLine("Hello World!");
            _callback.DoWork();
        }
    }
}