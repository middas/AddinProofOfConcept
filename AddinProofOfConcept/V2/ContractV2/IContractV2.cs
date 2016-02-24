using System;
using System.AddIn.Contract;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractV2.V2
{
    [AddInContract]
    public interface IContractV2 : IContract
    {
        string GetName();

        void WriteToConsole(string output);

        void Initialize(ICallbackContractV2 callback);
    }
}
