using System.AddIn.Contract;

namespace ContractV1.V1
{
    public interface ICallbackContractV1 : IContract
    {
        void DoWork();
    }
}