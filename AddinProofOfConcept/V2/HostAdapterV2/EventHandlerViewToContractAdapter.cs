using ContractV2.V2;
using System;
using System.AddIn.Pipeline;

namespace HostAdapterV2
{
    internal class EventHandlerViewToContractAdapter : ContractBase, IEventHandlerContractV2
    {
        private Action<string> _event;

        public EventHandlerViewToContractAdapter(Action<string> @event)
        {
            _event = @event;
        }

        public void Handle(string message)
        {
            _event(message);
        }
    }
}