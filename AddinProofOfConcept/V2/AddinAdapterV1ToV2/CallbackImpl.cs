using AddinView.V1;
using ContractV2.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
