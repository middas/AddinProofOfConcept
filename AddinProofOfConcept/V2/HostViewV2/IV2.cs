using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostViewV2.V2
{
    public interface IV2
    {
        string GetName();

        void WriteToConsole(string output);

        void Initialize(ICallbackV2 callback);
    }
}
