using AddinView.V1;
using ContractV2.V2;

namespace AddinAdapterV1ToV2
{
    public class CallbackImpl : ICallback
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