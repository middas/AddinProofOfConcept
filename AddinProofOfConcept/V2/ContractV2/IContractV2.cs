using System.AddIn.Contract;
using System.AddIn.Pipeline;

namespace ContractV2.V2
{
    [AddInContract]
    public interface IContractV2 : IContract
    {
        string GetName();

        void Initialize(ICallbackContractV2 callback);

        void WriteToConsole(string output);

        object GetSource();
    }
}