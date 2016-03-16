using ContractV2.V2;
using HostViewV2.V2;
using System;
using System.AddIn.Pipeline;

namespace HostAdapterV2.V2
{
    [HostAdapter]
    public class HostAdapter : IV2
    {
        private IContractV2 _contract;
        private ContractHandle _handle;

        public HostAdapter(IContractV2 contract)
        {
            _contract = contract;
            _handle = new ContractHandle(contract);
        }

        public event EventHandler<string> OnEvent
        {
            add
            {
                if (_OnEvent == null)
                {
                    _contract.OnEventAdd(new EventHandlerViewToContractAdapter(FireOnEvent));
                }

                _OnEvent += value;
            }
            remove
            {
                _OnEvent -= value;

                if (_OnEvent == null)
                {
                    _contract.OnEventRemove(new EventHandlerViewToContractAdapter(FireOnEvent));
                }
            }
        }

        private event EventHandler<string> _OnEvent;

        public string GetName()
        {
            return _contract.GetName();
        }

        public object GetSource()
        {
            return _contract.GetSource();
        }

        public void Initialize(ICallbackV2 callback)
        {
            _contract.Initialize(CallbackConverter.ToContract(callback));
        }

        public void WriteToConsole(string output)
        {
            _contract.WriteToConsole(output);
        }

        private void FireOnEvent(string message)
        {
            if (_OnEvent != null)
            {
                _OnEvent(this, message);
            }
        }
    }
}