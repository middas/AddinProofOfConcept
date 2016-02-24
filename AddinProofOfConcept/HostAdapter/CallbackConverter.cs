using ContractV1;
using HostView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostAdapter
{
    public class CallbackConverter
    {
        internal static ICallbackContractV1 ToContract(ICallback callback)
        {
            return new ContractImpl(callback);
        }
    }
}
