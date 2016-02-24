using ContractV2.V2;
using HostView.V1;

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