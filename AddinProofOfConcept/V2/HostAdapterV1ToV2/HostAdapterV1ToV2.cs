using ContractV2.V2;
using HostView.V1;
using System.AddIn.Pipeline;

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

        public void Initialize(ICallback callback)
        {
            _contract.Initialize(CallbackConverter.ToContractV1ToV2(callback));
        }

        public void WriteToConsole()
        {
            _contract.WriteToConsole("V1 doesn't support this");
        }
    }
}