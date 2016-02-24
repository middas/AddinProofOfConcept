using System;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddinViewV2.V2
{
    [AddInBase]
    public interface IV2
    {
        string GetName();

        void WriteToConsole(string output);

        void Initialize(ICallbackV2 callback);
    }
}
