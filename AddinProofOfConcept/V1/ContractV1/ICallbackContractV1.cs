using System;
using System.AddIn.Contract;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractV1.V1
{
    [AddInContract]
    public interface ICallbackContractV1 : IContract
    {
        void DoWork();
    }
}
