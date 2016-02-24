using AddinViewV2.V2;
using ContractV2.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddinAdapterV2.V2
{
    public class CallbackConverter
    {
        internal static ICallbackV2 FromContract(ICallbackContractV2 callback)
        {
            return new CallbackImpl(callback);
        }
    }
}
