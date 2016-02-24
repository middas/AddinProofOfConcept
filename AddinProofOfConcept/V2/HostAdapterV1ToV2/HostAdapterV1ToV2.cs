using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.AddIn.Pipeline;
using HostView.V1;
using ContractV2.V2;

namespace HostAdapterV1ToV2.V2
{
    [HostAdapter]
    public class HostAdapterV1ToV2 : IV1
    {
        private IContractV2 _contract;
        private ContractHandle _handler;

        public HostAdapterV1ToV2(IContractV2 contract)
        {
            _contract = contract;
            _handler = new ContractHandle(contract);
        }

        public string GetName()
        {
            return _contract.GetName();
        }

        public void WriteToConsole()
        {
            _contract.WriteToConsole("V1 doesn't support this");
        }

        public void Initialize(ICallback callback)
        {
            _contract.Initialize(CallbackConverter.ToContractV1ToV2(callback));
        }
    }
}
