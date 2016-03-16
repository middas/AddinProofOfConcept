using AddinViewV2.V2;
using ContractV2.V2;
using System;
using System.AddIn.Pipeline;
using System.Collections.Generic;

namespace AddinAdapterV2.V2
{
    [AddInAdapter]
    public class AddinAdapter : ContractBase, IContractV2
    {
        private Dictionary<IEventHandlerContractV2, EventHandler<string>> _eventHandlers = new Dictionary<IEventHandlerContractV2, EventHandler<string>>();
        private IV2 _view;

        public AddinAdapter(IV2 view)
        {
            _view = view;
        }

        public string GetName()
        {
            return _view.GetName();
        }

        public object GetSource()
        {
            return _view.GetSource();
        }

        public void Initialize(ICallbackContractV2 callback)
        {
            _view.Initialize(CallbackConverter.FromContract(callback));
        }

        public void OnEventAdd(IEventHandlerContractV2 handler)
        {
            EventHandler<string> adaptedEvent = EventHandlerAdapter.ContractToViewAdapter(handler);
            _eventHandlers.Add(handler, adaptedEvent);
            _view.OnEvent += adaptedEvent;
        }

        public void OnEventRemove(IEventHandlerContractV2 handler)
        {
            EventHandler<string> adaptedEvent;
            if (_eventHandlers.TryGetValue(handler, out adaptedEvent))
            {
                _eventHandlers.Remove(handler);
                _view.OnEvent -= adaptedEvent;
            }
        }

        public void WriteToConsole(string output)
        {
            _view.WriteToConsole(output);
        }
    }
}