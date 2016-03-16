using ContractV2.V2;
using System.AddIn.Pipeline;

namespace AddinAdapterV2
{
    internal class EventHandlerContractToViewAdapter
    {
        private IEventHandlerContractV2 _contract;
        private ContractHandle _handle;

        public EventHandlerContractToViewAdapter(IEventHandlerContractV2 contract)
        {
            _contract = contract;
            _handle = new ContractHandle(_contract);
        }

        internal void Handler(object sender, string message)
        {
            _contract.Handle(message);
        }
    }
}