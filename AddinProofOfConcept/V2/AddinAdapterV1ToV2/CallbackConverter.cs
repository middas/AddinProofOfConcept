using AddinView.V1;
using ContractV2.V2;

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