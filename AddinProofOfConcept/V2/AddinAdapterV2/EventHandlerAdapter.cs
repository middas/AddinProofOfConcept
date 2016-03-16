using ContractV2.V2;
using System;

namespace AddinAdapterV2
{
    internal class EventHandlerAdapter
    {
        internal static EventHandler<string> ContractToViewAdapter(IEventHandlerContractV2 handler)
        {
            return new EventHandlerContractToViewAdapter(handler).Handler;
        }
    }
}