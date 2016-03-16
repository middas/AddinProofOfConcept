using System;

namespace HostViewV2.V2
{
    public interface IV2
    {
        event EventHandler<string> OnEvent;

        string GetName();

        object GetSource();

        void Initialize(ICallbackV2 callback);

        void WriteToConsole(string output);
    }
}