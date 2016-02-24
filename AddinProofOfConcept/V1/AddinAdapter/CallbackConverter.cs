using AddinView.V1;
using ContractV1.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddinAdapter.V1
{
    public class CallbackConverter
    {
        internal static ICallback FromContract(ICallbackContractV1 callback)
        {
            return new CallbackImpl(callback);
        }
    }
}
