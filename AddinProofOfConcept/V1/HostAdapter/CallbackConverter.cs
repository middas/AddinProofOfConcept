using ContractV1.V1;
using HostView.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostAdapter.V1
{
    public class CallbackConverter
    {
        internal static ICallbackContractV1 ToContract(ICallback callback)
        {
            return new ContractImpl(callback);
        }
    }
}
