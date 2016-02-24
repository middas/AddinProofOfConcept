using ContractV2.V2;
using HostViewV2.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.AddIn.Pipeline;

namespace HostAdapterV2.V2
{
    [HostAdapter]
    public class HostAdapter : IV2
    {
        private IContractV2 _contract;
        private ContractHandle _handle;

        public HostAdapter(IContractV2 contract)
        {
            _contract = contract;
            _handle = new ContractHandle(contract);
        }

        public string GetName()
        {
            return _contract.GetName();
        }

        public void WriteToConsole(string output)
        {
            _contract.WriteToConsole(output);
        }

        public void Initialize(ICallbackV2 callback)
        {
            _contract.Initialize(CallbackConverter.ToContract(callback));
        }
    }
}
