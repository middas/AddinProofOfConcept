using System.AddIn.Pipeline;

namespace AddinView
{
    [AddInBase]
    public interface IV1
    {
        string GetName();

        void WriteToConsole();

        void Initialize(ICallback callback);
    }
}