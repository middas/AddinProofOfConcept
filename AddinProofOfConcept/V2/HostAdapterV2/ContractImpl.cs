using ContractV2.V2;
using HostViewV2.V2;
using System.AddIn.Pipeline;

namespace HostAdapterV2.V2
{
    public class ContractImpl : ContractBase, ICallbackContractV2
    {
        private ICallbackV2 _view;

        public ContractImpl(ICallbackV2 view)
        {
            _view = view;
        }

        public void DoWork()
        {
            _view.DoWork();
        }
    }
}