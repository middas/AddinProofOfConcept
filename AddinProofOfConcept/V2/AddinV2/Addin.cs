using AddinViewV2.V2;
using System;
using System.AddIn;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddinV2.V2
{
    [AddIn("Addin V2", Version = "2.0.0.0")]
    public class Addin : IV2
    {
        ICallbackV2 _callback;

        public string GetName()
        {
            return "Addin V2";
        }

        public void WriteToConsole(string output)
        {
            Console.WriteLine("Writing output from host: {0}", output);
            _callback.DoWork();
        }

        public void Initialize(ICallbackV2 callback)
        {
            _callback = callback;
        }
    }
}
