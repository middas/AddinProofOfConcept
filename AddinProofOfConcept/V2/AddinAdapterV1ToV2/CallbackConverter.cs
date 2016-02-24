using AddinView.V1;
using ContractV2.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddinAdapterV1ToV2.V2
{
    public class CallbackConverter
    {
        internal static ICallback FromContractV2(ICallbackContractV2 callback)
        {
            return new CallbackImpl(callback);
        }
    }
}
