using System.AddIn.Contract;

namespace ContractV2.V2
{
    public interface ICallbackContractV2 : IContract
    {
        void DoWork();
    }
}