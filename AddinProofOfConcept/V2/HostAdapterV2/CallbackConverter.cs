using ContractV2.V2;
using HostViewV2.V2;

namespace HostAdapterV2.V2
{
    public class CallbackConverter
    {
        internal static ICallbackContractV2 ToContract(ICallbackV2 callback)
        {
            return new ContractImpl(callback);
        }
    }
}