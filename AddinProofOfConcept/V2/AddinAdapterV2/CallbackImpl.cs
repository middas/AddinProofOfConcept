using AddinViewV2.V2;
using ContractV2.V2;

namespace AddinAdapterV2.V2
{
    public class CallbackImpl : ICallbackV2
    {
        private ICallbackContractV2 _contract;

        public CallbackImpl(ICallbackContractV2 contract)
        {
            _contract = contract;
        }

        public void DoWork()
        {
            _contract.DoWork();
        }
    }
}