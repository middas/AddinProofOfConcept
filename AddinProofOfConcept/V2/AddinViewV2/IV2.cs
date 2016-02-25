using System.AddIn.Pipeline;

namespace AddinViewV2.V2
{
    [AddInBase]
    public interface IV2
    {
        string GetName();

        void Initialize(ICallbackV2 callback);

        void WriteToConsole(string output);

        object GetSource();
    }
}