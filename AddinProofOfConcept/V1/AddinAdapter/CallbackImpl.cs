using AddinView.V1;
using ContractV1.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddinAdapter.V1
{
    public class CallbackImpl : ICallback
    {
        private ICallbackContractV1 _contract;

        public CallbackImpl(ICallbackContractV1 contract)
        {
            _contract = contract;
        }

        public void DoWork()
        {
            _contract.DoWork();
        }
    }
}
