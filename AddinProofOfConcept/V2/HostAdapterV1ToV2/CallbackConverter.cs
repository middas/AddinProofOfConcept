using ContractV2.V2;
using HostView.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostAdapterV1ToV2.V2
{
    public class CallbackConverter
    {
        internal static ICallbackContractV2 ToContractV1ToV2(ICallback callback)
        {
            return new ContractImpl(callback);
        }
    }
}
