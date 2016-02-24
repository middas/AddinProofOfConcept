using ContractV1;
using HostView;
using System;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostAdapter
{
    public class ContractImpl : ContractBase, ICallbackContractV1
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
