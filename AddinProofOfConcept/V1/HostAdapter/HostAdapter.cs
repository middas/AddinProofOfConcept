using ContractV1.V1;
using HostView.V1;
using System.AddIn.Pipeline;

namespace HostAdapter.V1
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