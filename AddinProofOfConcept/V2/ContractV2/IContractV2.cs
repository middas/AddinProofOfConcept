using System.AddIn.Contract;
using System.AddIn.Pipeline;

namespace ContractV2.V2
{
    [AddInContract]
    public interface IContractV2 : IContract
    {
        string GetName();

        object GetSource();

        void Initialize(ICallbackContractV2 callback);

        void OnEventAdd(IEventHandlerContractV2 handler);

        void OnEventRemove(IEventHandlerContractV2 handler);

        void WriteToConsole(string output);
    }

    public interface IEventHandlerContractV2 : IContract
    {
        void Handle(string message);
    }
}