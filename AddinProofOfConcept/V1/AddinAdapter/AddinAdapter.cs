using AddinView.V1;
using ContractV1.V1;
using System.AddIn.Pipeline;

namespace AddinAdapter.V1
{
    [AddInAdapter]
    public class AddinAdapter : ContractBase, IContractV1
    {
        private IV1 _contract;

        public AddinAdapter(IV1 contract)
        {
            _contract = contract;
        }

        public string GetName()
        {
            return _contract.GetName();
        }

        public void WriteToConsole()
        {
            _contract.WriteToConsole();
        }

        public void Initialize(ICallbackContractV1 callback)
        {
            _contract.Initialize(CallbackConverter.FromContract(callback));
        }
    }
}