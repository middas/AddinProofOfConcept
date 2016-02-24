using ContractV1;
using HostView;
using System.AddIn.Pipeline;

namespace HostAdapter
{
    [HostAdapter]
    public class HostAdapter : IV1
    {
        private IContractV1 _contract;
        private ContractHandle _handle;

        public HostAdapter(IContractV1 contract)
        {
            _contract = contract;
            _handle = new ContractHandle(contract);
        }

        public string GetName()
        {
            return _contract.GetName();
        }

        public void WriteToConsole()
        {
            _contract.WriteToConsole();
        }

        public void Initialize(ICallback callback)
        {
            _contract.Initialize(CallbackConverter.ToContract(callback));
        }
    }
}