using AddinViewV2.V2;
using System;
using System.AddIn;

namespace AddinV2.V2
{
    [AddIn("Addin V2", Version = "2.0.0.0")]
    public class Addin : IV2
    {
        private ICallbackV2 _callback;

        public event EventHandler<string> OnEvent;

        public string GetName()
        {
            return "Addin V2";
        }

        public object GetSource()
        {
            return "string as object";
        }

        public void Initialize(ICallbackV2 callback)
        {
            _callback = callback;

            if (OnEvent != null)
            {
                OnEvent(this, "Initialized called from Plugin");
            }
        }

        public void WriteToConsole(string output)
        {
            Console.WriteLine("Writing output from host: {0}", output);
            _callback.DoWork();
        }
    }
}