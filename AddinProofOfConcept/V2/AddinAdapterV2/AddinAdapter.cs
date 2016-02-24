using AddinViewV2.V2;
using ContractV2.V2;
using System.AddIn.Pipeline;

namespace AddinAdapterV2.V2
{
    [AddInAdapter]
    public class AddinAdapter : ContractBase, IContractV2
    {
        private IV2 _view;

        public AddinAdapter(IV2 view)
        {
            _view = view;
        }

        public string GetName()
        {
            return _view.GetName();
        }

        public void Initialize(ICallbackContractV2 callback)
        {
            _view.Initialize(CallbackConverter.FromContract(callback));
        }

        public void WriteToConsole(string output)
        {
            _view.WriteToConsole(output);
        }
    }
}