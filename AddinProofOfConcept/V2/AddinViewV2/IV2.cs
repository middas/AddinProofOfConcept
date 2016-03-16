using System;
using System.AddIn.Pipeline;

namespace AddinViewV2.V2
{
    [AddInBase]
    public interface IV2
    {
        event EventHandler<string> OnEvent;

        string GetName();

        object GetSource();

        void Initialize(ICallbackV2 callback);

        void WriteToConsole(string output);
    }
}