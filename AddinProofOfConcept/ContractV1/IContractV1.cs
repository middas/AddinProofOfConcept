using System.AddIn.Contract;
using System.AddIn.Pipeline;

namespace ContractV1
{
    [AddInContract]
    public interface IContractV1 : IContract
    {
        string GetName();

        void WriteToConsole();
    }
}