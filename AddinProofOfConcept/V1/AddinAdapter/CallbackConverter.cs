using AddinView.V1;
using ContractV1.V1;

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