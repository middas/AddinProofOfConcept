using AddinView;
using ContractV1;
using System.AddIn.Pipeline;

namespace AddinAdapter
{
    [AddInAdapter]
    public class AddinAdapter : ContractBase, IV1
    {
        private IContractV1 _contract;

        public AddinAdapter(IContractV1 contract)
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
    }
}