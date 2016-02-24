using ContractV1.V1;
using HostView.V1;

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