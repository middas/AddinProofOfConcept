using AddinView.V1;
using ContractV2.V2;
using System;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddinAdapterV1ToV2.V2
{
    [AddInAdapter]
    public class AddinAdapterV1ToV2 : ContractBase, IContractV2
    {
        private IV1 _view;

        public AddinAdapterV1ToV2(IV1 view)
        {
            _view = view;
        }

        public string GetName()
        {
            return _view.GetName();
        }

        public void WriteToConsole(string output)
        {
            Debug.WriteLine("Outout is ignored: ", output);
            _view.WriteToConsole();
        }

        public void Initialize(ICallbackContractV2 callback)
        {
            _view.Initialize(CallbackConverter.FromContractV2(callback));
        }
    }
}
