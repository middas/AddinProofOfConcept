using ContractV2.V2;
using HostView.V1;
using System;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostAdapterV1ToV2
{
    public class ContractImpl : ContractBase, ICallbackContractV2
    {
        private ICallback _callback;

        public ContractImpl(ICallback callback)
        {
            _callback = callback;
        }

        public void DoWork()
        {
            _callback.DoWork();
        }
    }
}
